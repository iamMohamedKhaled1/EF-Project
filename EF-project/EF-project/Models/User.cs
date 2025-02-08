using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_project.Models
{
    public class User
    {
        [Required]
        public int UserID { get; set; }
        [StringLength(100),Required]  
        public string Username { get; set; }
        [StringLength(50), Required]
        public string Password { get; set; }
        [StringLength(50), NotMapped]
        public string ConfirmPassword { get; set; }
        [StringLength(250), Required]
        public string Email { get; set; }
        public int? Age { get; set; }
        [StringLength(250)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string Role { get; set; } = "User";    

        public virtual List<Favorites> Favorites { get;}=new List<Favorites>();
    }
}
//This table stores user credentials for login and registration.
//Users ( UserId, Username, Password, Email, Age, Address, Role-- Admin or User );