using E_Shop.Data;
using E_Shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Data.ViewModels
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Название фильма")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string Name { get; set; }

        [Display(Name = "Описание фильма")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string Description { get; set; }

        [Display(Name = "Цена в руб.")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public double Price { get; set; }

        [Display(Name = "Постер")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string ImgUrl { get; set; }

        [Display(Name = "Дата выхода")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string DateReleased { get; set; }

        [Display(Name = "Жанр")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Выберите актера(ов)")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Выберите кинокомпанию")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public int CinemaId { get; set; }

        [Display(Name = "Выберите режиссера")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public int ProducerId { get; set; }
    }
}
