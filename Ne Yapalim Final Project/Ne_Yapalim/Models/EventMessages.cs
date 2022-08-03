using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("event_messages")]
    public partial class EventMessages
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("massege", TypeName = "text")]
        public string Massege { get; set; }
        [Column("sent_date", TypeName = "date")]
        public DateTime SentDate { get; set; }
        [Column("event_id")]
        public int? EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.EventMessages))]
        public virtual Events Event { get; set; }
    }
}
