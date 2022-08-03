using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ne_Yapalim.Data;
using Ne_Yapalim.Models;

namespace Ne_Yapalim.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private ApplicationDbContext context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;

        public IndexModel(
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager,
            ApplicationDbContext _context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            context = _context;
        }

        public string Username { get; set; }

   
        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            //Name ve Surname de ekle 
            [Column("name")]
            [StringLength(255)]
            public string Name { get; set; }
            [Column("surname")]
            [StringLength(255)]
            public string Surname { get; set; }
            [Column("birthdate", TypeName = "date")]
            public DateTime Birthdate { get; set; }
            [Column("profil_photo")]
            [StringLength(255)]
            public string ProfilPhoto { get; set; }
            [Column("about", TypeName = "text")]
            public string About { get; set; }
            public int City_Id { get; set; }
            public Cities Cities { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

        }

        private async Task LoadAsync(CustomUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var birthDate = user.Birthdate;
            var profilPhoto = user.ProfilPhoto;
            var about = user.About;
            var name = user.Name;
            var surname = user.SurName;
            var city = user.Cities;
            Username = userName;
             
            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Name = name,
                Surname = surname,
                Birthdate = birthDate,
                ProfilPhoto = profilPhoto,
                About = about,
                Cities = city,
            };
        }
       
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            List<SelectListItem> a = (from x in context.Cities.ToList()
                                      select new SelectListItem
                                      {
                                          Text = x.Name,
                                          Value = x.Id.ToString(),
                                      }).ToList();
            a.Insert(0, new SelectListItem()
            {
                Text = "Select",
                Value = string.Empty
            });

            ViewData["deneme"] = a;
        

        await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file)
        {
            var user = await _userManager.GetUserAsync(User);
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = user.Id + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");

                string deneme = $"{imageName}";
                user.ProfilPhoto = deneme;
                await _userManager.UpdateAsync(user);


                using var stream = new FileStream(path, FileMode.Create);

                await file.CopyToAsync(stream);

            }
            
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

           var name = user.Name;    
            if (Input.Name != name)
            {
                user.Name = Input.Name;
                await _userManager.UpdateAsync(user);
            }
            var surname = user.SurName;
            if (Input.Surname != surname)
            {
                user.SurName = Input.Surname;
                await _userManager.UpdateAsync(user);
            }

            var birhDate = user.Birthdate;
            if (Input.Birthdate != birhDate)
            {
                user.Birthdate = Input.Birthdate;
                await _userManager.UpdateAsync(user);

            }
            var about = user.About;
            if (Input.About != about)
            {
                user.About = Input.About;
                await _userManager.UpdateAsync(user);
            }

            var city = user.City_Id;
            if(Input.Cities.Id != city)
            {
                user.City_Id = Input.Cities.Id;
                await _userManager.UpdateAsync(user);
            }
            
               /* var ctId = context.Cities.Where(x => x.Id == user.City_Id).FirstOrDefault();
                user.Cities = ctId;
                user.City_Id = Input.City_Id;
                await _userManager.UpdateAsync(user);*/
           
            
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
