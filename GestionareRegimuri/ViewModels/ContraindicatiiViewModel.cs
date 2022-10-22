using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.ViewModels
{
    public class ContraindicatiiViewModel
    {
        public int ContraindicatieID { get; set; }
        [Required]
        public int AlimentID { get; set; }
        [Required]
        public string Boala { get; set; }
        [Required]
        public string Motiv { get; set; }
    }
}
