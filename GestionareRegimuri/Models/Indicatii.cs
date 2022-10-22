using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class Indicatii
    {
        public int IndicatiiID { get; set; }
        [Required]
        public int AlimentID { get; set; }
        [Required]
        public int BoalaID { get; set; }
        [Required]
        public string Motiv { get; set; }

        public Aliment Aliment { get; set; }

        public Boala Boala { get; set; }
    }
}
