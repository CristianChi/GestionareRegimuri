using GestionareRegimuri.Models;
using GestionareRegimuri.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareRegimuri.Utils.Services
{
    public class BoalaService : IBoalaService
    {
        private readonly IBoalaRepository _boalaRepository;

        public BoalaService(IBoalaRepository boalaRepository)
        {
            _boalaRepository = boalaRepository;
        }

        public ICollection<Boala> parseBoalas(string boalasString)
        {
            ICollection<Boala> boalas = new List<Boala>();
            var boalaNames = boalasString.Split(',').Select(name => name.Trim());
            foreach (var name in boalaNames)
            {
                var boala = _boalaRepository.FindByCondition(boala => boala.Nume == name).FirstOrDefault();
                if (boala == null)
                {
                    boala = new Boala() { Nume = name };
                }
                boalas.Add(boala);
            }
            return boalas;
        }

        public string stringifyBoalas(ICollection<Boala> boalas)
        {
            if (boalas == null)
            {
                return String.Empty;
            }
            return String.Join(", ", boalas.Select(boala => boala.Nume));
        }
    }
}
