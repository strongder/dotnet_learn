using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_project.Models
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
    }
}