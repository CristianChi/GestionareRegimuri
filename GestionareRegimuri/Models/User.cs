using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Models
{
    public class User : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Blacklisted { get; set; }

        public ICollection<Boala> Boli { get; set; }
    }
}
