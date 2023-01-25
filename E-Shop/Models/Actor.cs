using E_Shop.Data.Base;
using E_Shop.Data.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models
{
    public class Actor : Person
    {
        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
