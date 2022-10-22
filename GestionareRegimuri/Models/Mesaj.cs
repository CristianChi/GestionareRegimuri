using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class Mesaj
    {
        public int MesajID { get; set; }

        public int? UserID { get; set; }

        public User User { get; set; }

        [Required]
        public int ForumID { get; set; }

        [Required]
        public string MesajScris { get; set; }

        [Required]
        public DateTime Data { get; set; }
    }
}
