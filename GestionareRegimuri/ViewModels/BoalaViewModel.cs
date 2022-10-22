using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.ViewModels
{
    public class BoalaViewModel
    {

        public int BoalaID { get; set; }

        [Required]
        public string Nume { get; set; }
    }
}
