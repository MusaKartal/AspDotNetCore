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
    [Table("cities")]
    public partial class Cities
    {
        public Cities()
        {
            Districts = new HashSet<Districts>();
           
        }
       
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("City")]
        public virtual ICollection<Districts> Districts { get; set; }
       
        public virtual ICollection<CustomUser> CustomUsers { get; set; }

        
    }
}
