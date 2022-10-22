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
    public class IndicatiiController : Controller
    {
        private readonly IIndicatiiRepository _indicatiiRepository;
        private readonly IBoalaRepository _boalaRepository;

        public IndicatiiController(IIndicatiiRepository indicatiiRepository, IBoalaRepository boalaRepository)
        {
            _indicatiiRepository = indicatiiRepository;
            _boalaRepository = boalaRepository;
        }

        //Get: Indicatii
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _indicatiiRepository.FindAll().ToListAsync());
        }

        // GET: Indicatii/Create
        public IActionResult Create(int id)
        {
            IndicatiiViewModel indicatiiVM = new IndicatiiViewModel()
            {
                AlimentID = id
            };
            return View(indicatiiVM);
        }

        // POST: Indicatii/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IndicatiiViewModel indicatiiVM)
        {
            if (ModelState.IsValid)
            {
                var boala = _boalaRepository.FindByCondition(boala => boala.Nume == indicatiiVM.Boala).FirstOrDefault();
                if (boala == null)
                {
                    boala = new Boala() { Nume = indicatiiVM.Boala };
                    _boalaRepository.Create(boala);
                    _boalaRepository.Save();
                }
                Indicatii indicatii = new Indicatii()
                {
                    AlimentID = indicatiiVM.AlimentID,
                    BoalaID = boala.BoalaID,
                    Motiv = indicatiiVM.Motiv
                };
                _indicatiiRepository.Create(indicatii);
                _indicatiiRepository.Save();
                return RedirectToAction(nameof(Edit), new { id = indicatii.IndicatiiID });
            }
            return View(indicatiiVM);
        }

        // GET: Indicatii/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var indicatii = await _indicatiiRepository.FindByCondition(m => m.IndicatiiID == id).Include(c => c.Boala).FirstOrDefaultAsync();
            if (indicatii == null)
            {
                return NotFound();
            }
            IndicatiiViewModel indicatieVM = new IndicatiiViewModel()
            {
                IndicatiiID = indicatii.IndicatiiID,
                AlimentID = indicatii.AlimentID,
                Boala = indicatii.Boala.Nume,
                Motiv = indicatii.Motiv
            };

            return View(indicatieVM);
        }

        // POST: Indicatii/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IndicatiiViewModel indicatiiVM)
        {
            if (ModelState.IsValid)
            {

                Indicatii indicatii = _indicatiiRepository.FindByCondition(m => m.IndicatiiID == indicatiiVM.IndicatiiID).FirstOrDefault();

                if (indicatii == null)
                {
                    return NotFound();
                }
                var boala = _boalaRepository.FindByCondition(boala => boala.Nume == indicatiiVM.Boala).FirstOrDefault();
                if (boala == null)
                {
                    boala = new Boala() { Nume = indicatiiVM.Boala };
                    _boalaRepository.Create(boala);
                    _boalaRepository.Save();
                }

                //setting other values
                indicatii.AlimentID = indicatiiVM.AlimentID;
                indicatii.BoalaID = boala.BoalaID;
                indicatii.Motiv = indicatiiVM.Motiv;

                //success
                _indicatiiRepository.Update(indicatii);
                _indicatiiRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(indicatiiVM);
        }

        // GET: Indicatii/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicatie = _indicatiiRepository.FindByCondition(m => m.IndicatiiID == id).FirstOrDefault();
            if (indicatie == null)
            {
                return NotFound();
            }

            _indicatiiRepository.Delete(indicatie);
            _indicatiiRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }

}
