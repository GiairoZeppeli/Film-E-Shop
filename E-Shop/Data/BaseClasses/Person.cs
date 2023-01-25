using E_Shop.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Shop.Data.BaseClasses
{
    public class Person : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Name is Requried")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Display(Name = "Биография")]
        [Required(ErrorMessage = "Biography is Requried")]
        public string Bio { get; set; }

        [Display(Name = "Фото")]
        [Required(ErrorMessage = "Profile Picture is Requried")]
        public string ImgUrl { get; set; }
    }
}
