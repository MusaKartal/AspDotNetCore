using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ne_Yapalim.Data;
using Ne_Yapalim.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ne_Yapalim.Controllers
{
    public class EventController : Controller
    {
        private ApplicationDbContext context;
        public EventController(ApplicationDbContext _context)
        {

            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EventCreate()
        {
            //dropdownlist eventcategory bilgilerini yansıtıyorum 
            List<SelectListItem> event_c_list = (from x in context.EventCategories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString(),
                                                 }).ToList();
            event_c_list.Insert(0, new SelectListItem()
            {
                Text = "Seçiniz",
                Value = string.Empty
            });
            ViewBag.EventCtgr = event_c_list;
            return View();
        }
        [HttpPost]
        public IActionResult EventCreate(Events model, IFormFile file)
        {
            var event_Ctgr_id = context.EventCategories.Where
                (x => x.Id == model.EventCategory.Id)
                .FirstOrDefault();
            model.EventCategory = event_Ctgr_id;
            model.CustomUsers = GetLoggedInUser();
            context.Events.Add(model);
            context.SaveChanges();

            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = Guid.NewGuid() + imageExtension;

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/EventImage/{imageName}");

                using var stream = new FileStream(path, FileMode.Create);

                file.CopyToAsync(stream);

                var NewImage = new EventImage();
                NewImage.EventId = model.Id;
                NewImage.Image = imageName;
                context.EventImage.Add(NewImage);
                context.SaveChanges();
            }
            return RedirectToAction("HomePage","Account");
            
        }

        [Authorize]
        public IActionResult HomePage()
        {
            var event_show = context.Events
                .Include(x => x.CustomUsers)
                .Include(x => x.Attendees)
                 .Include(events => events.Attendees)
                    .ThenInclude(attendees => attendees.CustomUsers)
                    .Include(events => events.EventImage)
                    .ThenInclude(EventImage => EventImage.Event)
                .Include(x => x.EventCategory).ToList();


            return View(event_show);
        }
        public IActionResult EventView()
        {
            var claims_identity = (ClaimsIdentity)User.Identity;
            var claims = claims_identity
                .FindFirst(ClaimTypes.NameIdentifier);
            var event_show = context.Events
                   .Where(x => x.CustomUsers.Id == claims.Value)
                   .Include(x => x.EventCategory)
                   .Include(events => events.EventImage)
                    .ThenInclude(EventImage => EventImage.Event)
                   .Include(x => x.CustomUsers).ToList();

            return View(event_show);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var events = context.Events.Find(id);
            if (events == null)
            {
                return NotFound();
            }
            var event_show = context.Events
                  .Include(x => x.EventCategory)
                  .Include(x => x.EventImage)
                  .ThenInclude(x => x.Event)
                  .Include(x => x.CustomUsers).ToList();
            return View(events);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var events = context.Events.Find(id);
            var eventImages = context.EventImage.Where(image => image.EventId == id).ToArray();
            var attendees = context.Attendees.Where(attendee => attendee.EventId == id).ToArray();
            if (events == null) {
                return View();
            }

            context.EventImage.RemoveRange(events.EventImage);
            context.Attendees.RemoveRange(events.Attendees);
            context.Events.Remove(events);
            context.SaveChanges();

            return RedirectToAction("EventView");
        }
        private CustomUser GetLoggedInUser()
        {
            var claims_identity = (ClaimsIdentity)User.Identity;
            var claims = claims_identity
                .FindFirst(ClaimTypes.NameIdentifier);
            var user_id = context.CustomUsers
                .FirstOrDefault(u => u.Id == claims.Value);
            return user_id;
        }
        public IActionResult Edit(int id)
        {
            List<SelectListItem> event_c = (from x in context.EventCategories.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.Id.ToString(),
                                            }).ToList();
      
            ViewBag.EventCt = event_c;
            var events = context.Events.Find(id);
            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }

        [HttpPost]
        public IActionResult Edit(Events events, IFormFile file)
        {

            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = Guid.NewGuid() + imageExtension;

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/EventImage/{imageName}");

                using var stream = new FileStream(path, FileMode.Create);

                file.CopyToAsync(stream);


                var NewImage = context.EventImage.FirstOrDefault();
                NewImage.EventId = events.Id;
                NewImage.Image = imageName;
                context.EventImage.Update(NewImage);
                context.SaveChanges();
            }
            var event_Ctgr_id = context.EventCategories.Where
                (x => x.Id == events.EventCategory.Id)
                .FirstOrDefault();

            //   var updateEvents = new Events();
            events.CustomUsers = GetLoggedInUser();
            events.EventCategory = event_Ctgr_id;
            events.Location = events.Location;
            events.Title = events.Title;
            events.Description = events.Description;
            context.Events.Update(events);
            context.SaveChanges();

            return RedirectToAction("EventView");

        }

        public IActionResult Details(Events myEvent)
        {
            var event_details = context.Events
                 .Include(events => events.EventCategory)
                 .Include(events => events.Attendees)
                    .ThenInclude(attendees => attendees.CustomUsers)
                    .Include(events => events.EventImage)
                    .ThenInclude(EventImage => EventImage.Event)
                 .Include(events => events.CustomUsers)
                 .Where(events => events.Id == myEvent.Id).First();

            if (event_details == null)
            {
                return NotFound();
            }

            return View(event_details);
        }

    }
}
