using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string FullName { get; set; }

        [Display(Name = "Электронная почта")]
        [Required(ErrorMessage = "Поле является обязательным")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Подтвердить пароль")]
        [Required(ErrorMessage = "Необходимо подтвердить пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль не совпадает")]
        public string ConfirmPassword { get; set; }
    }
}
