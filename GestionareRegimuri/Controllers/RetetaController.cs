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
    public class RetetaController : Controller
    {
        private readonly IRetetaRepository _retetaRepository;
        private readonly IBoalaService _boalaService;

        public RetetaController(IRetetaRepository retetaRepository, IBoalaService boalaService)
        {
            _retetaRepository = retetaRepository;
            _boalaService = boalaService;
        }

        [AllowAnonymous]
        //Get: Reteta
        public async Task<IActionResult> Index(string childname)
        {
            if (string.IsNullOrEmpty(childname))
            {
                return View(await _retetaRepository.FindAll().ToListAsync());
            }


            return View(await _retetaRepository.FindByCondition(
                r => r.RetetaNume.ToUpper().Contains(childname.ToUpper()) ||
                     r.Boli.Select(b => b.Nume.ToUpper())
                        .Any(b => b.Contains(childname))
                     ).ToListAsync());
        }

        [AllowAnonymous]
        // GET: Aliment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reteta = await _retetaRepository.FindByCondition(m => m.RetetaID == id)
                .FirstOrDefaultAsync();

            if (reteta == null)
            {
                return NotFound();
            }

            else
            {
                ViewBag.Boli = new int[0];
            }
            return View(reteta);
        }

        // GET: Reteta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reteta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RetetaViewModel retetaVM)
        {
            if (ModelState.IsValid)
            {
                Reteta reteta = new Reteta()
                {
                    RetetaID = retetaVM.RetetaID,
                    Link = retetaVM.Link,
                    RetetaNume = retetaVM.RetetaNume,
                    Boli = _boalaService.parseBoalas(retetaVM.Boli)
                };
                _retetaRepository.Create(reteta);
                _retetaRepository.Save();
                return RedirectToAction(nameof(Edit), new { id = reteta.RetetaID });
            }
            return View(_retetaRepository);
        }

        // GET: Reteta/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var reteta = await _retetaRepository.FindByCondition(m => m.RetetaID == id).Include(r => r.Boli).FirstOrDefaultAsync();
            if (reteta == null)
            {
                return NotFound();
            }
            RetetaViewModel retetaVM = new RetetaViewModel()
            {
                RetetaID = reteta.RetetaID,
                Boli =  _boalaService.stringifyBoalas(reteta.Boli),
                RetetaNume = reteta.RetetaNume,
                Link = reteta.Link
            };

            return View(retetaVM);
        }

        // POST: Reteta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RetetaViewModel retetaVM)
        {
            if (ModelState.IsValid)
            {

                Reteta reteta = _retetaRepository.FindByCondition(m => m.RetetaID == retetaVM.RetetaID).FirstOrDefault();

                if (reteta == null)
                {
                    return NotFound();
                }

                _retetaRepository.LoadCollection(reteta, r => r.Boli);

                //setting other values
                reteta.RetetaID = retetaVM.RetetaID;
                reteta.Boli = _boalaService.parseBoalas(retetaVM.Boli);
                reteta.RetetaNume = retetaVM.RetetaNume;
                reteta.Link = retetaVM.Link;

                //success
                _retetaRepository.Update(reteta);
                _retetaRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(retetaVM);
        }

        // GET: Boala/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reteta = _retetaRepository.FindByCondition(m => m.RetetaID == id).FirstOrDefault();
            if (reteta == null)
            {
                return NotFound();
            }

            _retetaRepository.Delete(reteta);
            _retetaRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}