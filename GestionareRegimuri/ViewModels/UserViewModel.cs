using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.ViewModels
{
    public class UserViewModel : RegisterViewModel
    {
        [StringLength(100, ErrorMessage = "Parola trbuie sa aiba cel putin {2} caractere si maximum {1} caractere.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola noua(optional)")]
        new public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parola curenta")]
        public string CurrentPassword { get; set; }

        public string Boli { get; set; }
    }
}
