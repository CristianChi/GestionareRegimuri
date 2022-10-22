using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionareRegimuri.Data;
using GestionareRegimuri.Models;
using Microsoft.AspNetCore.Authorization;
using GestionareRegimuri.Utils.Services;
using GestionareRegimuri.ViewModels;
using Microsoft.AspNetCore.Identity;
using GestionareRegimuri.Repository.Interfaces;


namespace GestionareRegimuri.Controllers
{
    [Authorize(Roles = "Administrator,Medic")]
    public class ContraindicatiiController : Controller
    {
        private readonly IContraindicatiiRepository _contraindicatiiRepository;
        private readonly IBoalaRepository _boalaRepository;

        public ContraindicatiiController(IContraindicatiiRepository contraindicatiiRepository, IBoalaRepository boalaRepository)
        {
            _contraindicatiiRepository = contraindicatiiRepository;
            _boalaRepository = boalaRepository;
        }

        //Get: Contraindicatii
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _contraindicatiiRepository.FindAll().ToListAsync());
        }

        // GET: Contraindicatii/Create
        public IActionResult Create(int id)
        {
            ContraindicatiiViewModel contraindicatiiVM = new ContraindicatiiViewModel()
            {
                AlimentID = id
            };
            return View(contraindicatiiVM);
        }

        // POST: Contraindicatii/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContraindicatiiViewModel contraindicatiiVM)
        {
            if (ModelState.IsValid)
            {
                var boala = _boalaRepository.FindByCondition(boala => boala.Nume == contraindicatiiVM.Boala).FirstOrDefault();
                if (boala == null)
                {
                    boala = new Boala() { Nume = contraindicatiiVM.Boala };
                    _boalaRepository.Create(boala);
                    _boalaRepository.Save();
                }
                Contraindicatii contraindicatii = new Contraindicatii()
                {
                    AlimentID = contraindicatiiVM.AlimentID,
                    BoalaID = boala.BoalaID,
                    Motiv = contraindicatiiVM.Motiv
                };
                _contraindicatiiRepository.Create(contraindicatii);
                _contraindicatiiRepository.Save();
                return RedirectToAction(nameof(Edit), new { id = contraindicatii.ContraindicatieID });
            }
            return View(contraindicatiiVM);
        }

        // GET: Contraindicatii/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var contraindicatii = await _contraindicatiiRepository.FindByCondition(m => m.ContraindicatieID == id).Include(c => c.Boala).FirstOrDefaultAsync();
            if (contraindicatii == null)
            {
                return NotFound();
            }
            ContraindicatiiViewModel contraindicatiiVM = new ContraindicatiiViewModel()
            {
                ContraindicatieID = contraindicatii.ContraindicatieID,
                AlimentID = contraindicatii.AlimentID,
                Boala = contraindicatii.Boala.Nume,
                Motiv = contraindicatii.Motiv
            };

            return View(contraindicatiiVM);
        }

        // POST: Contraindicatii/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ContraindicatiiViewModel contraindicatiiVM)
        {
            if (ModelState.IsValid)
            {

                Contraindicatii contraindicatii = _contraindicatiiRepository.FindByCondition(m => m.ContraindicatieID == contraindicatiiVM.ContraindicatieID).FirstOrDefault();

                if (contraindicatii == null)
                {
                    return NotFound();
                }
                var boala = _boalaRepository.FindByCondition(boala => boala.Nume == contraindicatiiVM.Boala).FirstOrDefault();
                if (boala == null)
                {
                    boala = new Boala() { Nume = contraindicatiiVM.Boala };
                    _boalaRepository.Create(boala);
                    _boalaRepository.Save();
                }
                //setting other values
                contraindicatii.AlimentID = contraindicatiiVM.AlimentID;
                contraindicatii.BoalaID = boala.BoalaID;
                contraindicatii.Motiv = contraindicatiiVM.Motiv;

                //success
                _contraindicatiiRepository.Update(contraindicatii);
                _contraindicatiiRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(contraindicatiiVM);
        }

        // GET: Contraindicatii/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contraindicatie = _contraindicatiiRepository.FindByCondition(m => m.ContraindicatieID == id).FirstOrDefault();
            if (contraindicatie == null)
            {
                return NotFound();
            }

            _contraindicatiiRepository.Delete(contraindicatie);
            _contraindicatiiRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }

}
