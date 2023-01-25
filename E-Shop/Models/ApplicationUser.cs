using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Shop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Имя")]
        public string FullName { get; set; }
    }
}