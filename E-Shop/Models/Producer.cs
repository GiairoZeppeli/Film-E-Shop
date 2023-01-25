using E_Shop.Data.Base;
using E_Shop.Data.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models
{
    public class Producer : Person
    {
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
