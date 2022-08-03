using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Models
{
    [Table("user_hobby")]
    public partial class UserHobby
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hobby_id")]
        public int? HobbyId { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }

        [ForeignKey(nameof(HobbyId))]
        [InverseProperty(nameof(Hobbies.UserHobby))]
        public virtual Hobbies Hobby { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.UserHobby))]
        public virtual Users User { get; set; }
    }
}
