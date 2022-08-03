using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

namespace Ne_Yapalim.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext context;
        public AccountController(ApplicationDbContext _context)
        {
          
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            var city_Include = context.Users
                .Include(x => x.Cities).ToList();
            return View(city_Include);
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
      


        [HttpPost]
        public IActionResult Join(int id)
        {
            var events = context.Events.Find(id);
            var newAttendee = new Attendees();
            newAttendee.CustomUsers = GetLoggedInUser();
            newAttendee.Event = events;
            context.Attendees.Add(newAttendee);
            context.SaveChanges();

            return RedirectToAction("HomePage");
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

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var events = context.Events.Find(id);

            var attendeeRecord = context.Attendees.Where(attendee => attendee.Event.Id == id && attendee.CustomUsers.Id == GetLoggedInUser().Id).First();
            context.Remove(attendeeRecord);
            context.SaveChanges();

            return RedirectToAction("HomePage");
        }
        public  IActionResult Edit(int id)
        {
            List<SelectListItem> event_c = (from x in context.EventCategories.ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.Name,
                                           Value = x.Id.ToString(),
                                       }).ToList();
                                       event_c.Insert(0, new SelectListItem()
                                       {
                                         Text = "Seçiniz",
                                         Value = string.Empty
                                       });
            ViewBag.EventCt = event_c;
            var events = context.Events.Find(id);
            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }

        [HttpPost] 
        public IActionResult Edit(Events events,IFormFile file)
        {
            
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = Guid.NewGuid() + imageExtension;

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/EventImage/{imageName}");

                using var stream = new FileStream(path, FileMode.Create);

                file.CopyToAsync(stream);


                var NewImage = context.EventImage.FirstOrDefault();
                NewImage.EventId = events.Id ;
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
