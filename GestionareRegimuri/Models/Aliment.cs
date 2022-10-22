using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class Aliment
    {
        public int AlimentID { get; set; }

        [Required]
        public string Nume { get; set; }
        [Required]
        public string Categorie { get; set; }
        [Required]
        public int Glucide { get; set; }
        [Required]
        public int Proteine { get; set; }
        [Required]
        public int Lipide { get; set; }
        [Required]
        public int Calorii { get; set; }

        public ICollection<Indicatii> Indicatii { get; set; }

        public ICollection<Contraindicatii> Contraindicatii { get; set; }
    }

    
}
