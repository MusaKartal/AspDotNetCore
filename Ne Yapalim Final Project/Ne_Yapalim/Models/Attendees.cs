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
    [Table("attendees")]
    public partial class Attendees
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("event_id")]
        public int? EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.Attendees))]
        public virtual Events Event { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(CustomUser.Attendees))]
        public virtual CustomUser CustomUsers { get; set; }


    }
}
