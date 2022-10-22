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
    public class BoalaController : Controller
    {
        private readonly IBoalaRepository _boalaRepository;

        public BoalaController(IBoalaRepository boalaRepository)
        {
            _boalaRepository = boalaRepository;
        }

        //Get: Boala
        public async Task<IActionResult> Index(string childname)
        {
            if (string.IsNullOrEmpty(childname))
            {
                return View(await _boalaRepository.FindAll().ToListAsync());
            }
            return View(await _boalaRepository.FindByCondition(b => b.Nume.ToUpper().Contains(childname.ToUpper())).ToListAsync());
        }

        // GET: Boala/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boala/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BoalaViewModel boalaVM)
        {
            if (ModelState.IsValid)
            {
                Boala boala = new Boala()
                {
                    BoalaID = boalaVM.BoalaID,
                    Nume = boalaVM.Nume
                };
                _boalaRepository.Create(boala);
                _boalaRepository.Save();
                return RedirectToAction(nameof(Edit), new { id = boala.BoalaID });
            }
            return View(_boalaRepository);
        }

        // GET: Boala/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var boala = await _boalaRepository.FindByCondition(m => m.BoalaID == id).FirstOrDefaultAsync();
            if (boala == null)
            {
                return NotFound();
            }
            BoalaViewModel boalaVM = new BoalaViewModel()
            {
                BoalaID = boala.BoalaID,
                Nume = boala.Nume
            };

            return View(boalaVM);
        }

        // POST: Boala/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BoalaViewModel boalaVM)
        {
            if (ModelState.IsValid)
            {

                Boala boala = _boalaRepository.FindByCondition(m => m.BoalaID == id).FirstOrDefault();

                if (boala == null)
                {
                    return NotFound();
                }

                //setting other values
                boala.BoalaID = boalaVM.BoalaID;
                boala.Nume = boalaVM.Nume;

                //success
                _boalaRepository.Update(boala);
                _boalaRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(boalaVM);
        }

        // GET: Boala/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boala = _boalaRepository.FindByCondition(m => m.BoalaID == id).FirstOrDefault();
            if (boala == null)
            {
                return NotFound();
            }

            _boalaRepository.Delete(boala);
            _boalaRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}