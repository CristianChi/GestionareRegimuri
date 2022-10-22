using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.ViewModels
{
    public class MesajViewModel
    {
        public int MesajID { get; set; }

        public int UserID { get; set; }

        [Required]
        public int ForumID { get; set; }

        [Required]
        public string MesajScris { get; set; }

        public DateTime Data { get; set; }
    }
}
