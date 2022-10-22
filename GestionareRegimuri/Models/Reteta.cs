using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class Reteta
    {
        [Required]
        public int RetetaID { get; set; }
        [Required]
        public string RetetaNume { get; set; }

        [Required]
        public string Link { get; set; }

        public ICollection<Boala> Boli { get; set; }
    }
}
