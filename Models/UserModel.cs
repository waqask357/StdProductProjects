using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StdProductProjects.Models
{
    [Table("UserTable")]
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(150)]
        public string ContactNo { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(200)]
        public string Username { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(200)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}