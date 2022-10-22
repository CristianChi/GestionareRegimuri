using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionareRegimuri.Data;
using GestionareRegimuri.Models;
using GestionareRegimuri.Repository.Interfaces;

namespace GestionareRegimuri.Controllers
{
    public class AlimentController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IAlimentRepository _alimentRepository;
        private readonly IUserRepository _userRepository;

        public AlimentController(IAlimentRepository alimentRepository, IUserRepository userRepository)
        {
            _alimentRepository = alimentRepository;
            _userRepository = userRepository;
        }

        // GET: Aliment
        public async Task<IActionResult> Index(string childname)
        {
            if (string.IsNullOrEmpty(childname))
            {
                return View(await _alimentRepository.FindAll().ToListAsync());
            }
            return View(await _alimentRepository.FindByCondition(b => b.Nume.ToUpper().Contains(childname.ToUpper())).ToListAsync());
        }
        //{
        //    return View(await alimentRepository.FindAll().ToListAsync());
        //}

        // GET: Aliment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aliment = await _alimentRepository.FindByCondition(m => m.AlimentID == id)
                .Include(a => a.Indicatii)
                    .ThenInclude(i => i.Boala)
                .Include(a => a.Contraindicatii)
                    .ThenInclude(i => i.Boala)
                .FirstOrDefaultAsync();

            if (aliment == null)
            {
                return NotFound();
            }

            if (User.Identity.IsAuthenticated)
            {
                var user = await _userRepository.getCurrentUserAsync(User);
                _userRepository.LoadCollection(user, u => u.Boli);
                ViewBag.Boli = user.Boli.Select(b => b.BoalaID).ToArray();
            }
            else
            {
                ViewBag.Boli = new int[0];
            }
            return View(aliment);
        }

        // GET: Aliment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aliment/Create/1
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("AlimentID,Nume,Categorie,Glucide,Proteine,Lipide,Calorii")] Aliment aliment)
        {
            if (ModelState.IsValid)
            {
                _alimentRepository.Create(aliment);
                _alimentRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(aliment);
        }

        // GET: Aliment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aliment = await _alimentRepository.FindByCondition(m => m.AlimentID == id).FirstOrDefaultAsync();
            if (aliment == null)
            {
                return NotFound();
            }
            return View(aliment);
        }

        // POST: Aliment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlimentID,Nume,Categorie,Glucide,Proteine,Lipide,Calorii")] Aliment aliment)
        {
            if (id != aliment.AlimentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _alimentRepository.Update(aliment);
                    _alimentRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _alimentRepository.FindByCondition(m => m.AlimentID == id).AnyAsync())
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aliment);
        }

        // GET: Aliment/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aliment = _alimentRepository.FindByCondition(m => m.AlimentID == id).FirstOrDefault();
            if (aliment == null)
            {
                return NotFound();
            }

            return View(aliment);
        }

        // POST: Aliment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aliment = await _alimentRepository.FindByCondition(m => m.AlimentID == id).FirstOrDefaultAsync();
            _alimentRepository.Delete(aliment);
            _alimentRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
