using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.ViewModels
{
    public class ForumViewModel
    {
        public int DiscutieID { get; set; }
        public string Nume { get; set; }
        [Required]
        public string Titlu { get; set; }
        public DateTime? Data { get; set; }
    }
}
