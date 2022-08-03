using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("event_image")]
    public partial class EventImage
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Resim Alanı Gereklidir")]
        [Column("image")]
        [StringLength(255)]
        public string Image { get; set; }
        [Column("event_id")]
        public int? EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.EventImage))]
        public virtual Events Event { get; set; }
    }
}
