using Microsoft.AspNetCore.Identity;
using Ne_Yapalim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ne_Yapalim.Data
{
    public class CustomUser : IdentityUser
    {

        public CustomUser()
        {
            Attendees = new HashSet<Attendees>();
            Events = new HashSet<Events>();
           
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        [Required(ErrorMessage = "Doğum Tarihi Gereklidir")]
        public DateTime Birthdate { get; set; }
        public string ProfilPhoto { get; set; }
        public string About { get; set; }
        public int? City_Id { get; set; }

        [ForeignKey(nameof(City_Id))]
        public Cities Cities { get; set; }


        [InverseProperty("CustomUsers")]
        public virtual ICollection<Attendees> Attendees { get; set; }

        [InverseProperty("CustomUsers")]
        public virtual ICollection<Events> Events { get; set; }


    }
}