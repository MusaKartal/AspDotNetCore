using Microsoft.AspNetCore.Identity;
using Ne_Yapalim.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("events")]
    public partial class Events
    {
        public Events()
        {
            Attendees = new HashSet<Attendees>();
            EventImage = new HashSet<EventImage>();
            EventMessages = new HashSet<EventMessages>();
            EventScoring = new HashSet<EventScoring>();
            EventTags = new HashSet<EventTags>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Başlık Alanı Gereklidir")]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Konum Alanı Gereklidir")]
        [Column("location", TypeName = "text")]
        public string Location { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Tarih Alanı Gereklidir")]
        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Kategori Alanı Gereklidir")]
        [Column("event_category_id")]
        public int EventCategoryId { get; set; }
        [Column("user_id")]
        [StringLength(450)]
        public string CId { get; set; }
    
        [ForeignKey(nameof(EventCategoryId))]
        [InverseProperty(nameof(EventCategories.Events))]
        public virtual EventCategories EventCategory { get; set; }
        [ForeignKey(nameof(CId))]
        [InverseProperty(nameof(CustomUser.Events))]
        public virtual CustomUser CustomUsers { get; set; }
        //public virtual Users User { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<Attendees> Attendees { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<EventImage> EventImage { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<EventMessages> EventMessages { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<EventScoring> EventScoring { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<EventTags> EventTags { get; set; }
    }
}
