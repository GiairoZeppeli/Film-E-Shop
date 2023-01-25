using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Электронная почта")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
