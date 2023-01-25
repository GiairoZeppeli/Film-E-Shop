using E_Shop.Data.Base;
using E_Shop.Data.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Кинокомпания")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Лого")]
        public string ImgUrl { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
