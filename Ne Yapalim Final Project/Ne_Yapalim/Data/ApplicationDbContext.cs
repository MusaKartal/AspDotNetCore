using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ne_Yapalim.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ne_Yapalim.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Attendees> Attendees { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<EventCategories> EventCategories { get; set; }
        public virtual DbSet<EventImage> EventImage { get; set; }
        public virtual DbSet<EventMessages> EventMessages { get; set; }
        public virtual DbSet<EventScoring> EventScoring { get; set; }
        public virtual DbSet<EventTags> EventTags { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Hobbies> Hobbies { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<UserHobby> UserHobby { get; set; }
        public virtual DbSet<CustomUser> CustomUsers { get; set; }
    }

}
