using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_project.Models
{
    [Table("users")]
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Dob { get; set; }    
    }
}