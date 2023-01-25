using E_Shop.Data.Base;
using E_Shop.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Shop.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Цена")]
        public double Price { get; set; }
        [Display(Name = "Постер")]
        public string ImgUrl { get; set; }
        [Display(Name = "Дата выхода")]
        public string DateReleased { get; set; } 
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        //Actors
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
