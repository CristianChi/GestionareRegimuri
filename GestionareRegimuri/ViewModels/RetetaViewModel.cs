using GestionareRegimuri.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.ViewModels
{
    public class RetetaViewModel
    {
        [Required]
        public int RetetaID { get; set; }
        [Required]
        public string Boli { get; set; }
        [Required]
        public string RetetaNume { get; set; }

        [Required]
        public string Link { get; set; }

    }
}
