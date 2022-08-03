using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("users")]
    public partial class Users
    {
        public Users()
        {
           // Attendees = new HashSet<Attendees>();
            EventScoring = new HashSet<EventScoring>();
          
            UserHobby = new HashSet<UserHobby>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("new_id")]
        [StringLength(255)]
        public string NewId { get; set; }

       // [InverseProperty("User")]
     //   public virtual ICollection<Attendees> Attendees { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<EventScoring> EventScoring { get; set; }
       
        [InverseProperty("User")]
        public virtual ICollection<UserHobby> UserHobby { get; set; }
    }
}
