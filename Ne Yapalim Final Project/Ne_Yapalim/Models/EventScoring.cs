using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("event_scoring")]
    public partial class EventScoring
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("point")]
        public double? Point { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Column("event_id")]
        public int? EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.EventScoring))]
        public virtual Events Event { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.EventScoring))]
        public virtual Users User { get; set; }
    }
}
