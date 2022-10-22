using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class Forum
    {
        [Key]
        public int DiscutieID { get; set; }

        [Required]
        public int UserID { get; set; }

        public User User { get; set; }

        [Required]
        public string Titlu { get; set; }

        public ICollection<Mesaj> Mesaje { get; set; }
    }
}
