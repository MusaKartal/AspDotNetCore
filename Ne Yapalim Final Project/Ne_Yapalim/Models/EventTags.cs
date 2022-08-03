using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("event_tags")]
    public partial class EventTags
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("event_id")]
        public int? EventId { get; set; }
        [Column("tag_id")]
        public int? TagId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.EventTags))]
        public virtual Events Event { get; set; }
        [ForeignKey(nameof(TagId))]
        [InverseProperty(nameof(Tags.EventTags))]
        public virtual Tags Tag { get; set; }
    }
}
