using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class Boala
    {
        public int BoalaID { get; set; }

        [Required]
        public string Nume { get; set; }

        public ICollection<Indicatii> Indicatii { get; set; }

        public ICollection<Contraindicatii> Contraindicatii { get; set; }

        public ICollection<Reteta> Retete { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
