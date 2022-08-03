using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("tags")]
    public partial class Tags
    {
        public Tags()
        {
            EventTags = new HashSet<EventTags>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("Tag")]
        public virtual ICollection<EventTags> EventTags { get; set; }
    }
}
