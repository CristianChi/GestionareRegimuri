using GestionareRegimuri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionareRegimuri.Utils.Services
{
    public interface IBoalaService
    {
        ICollection<Boala> parseBoalas(string boalasString);
        string stringifyBoalas(ICollection<Boala> boalas);
    }
}
