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
    public class MesajController : Controller
    {
        private readonly IMesajRepository _mesajRepository;
        private readonly UserManager<User> _userManager;

        public MesajController(IMesajRepository mesajRepository, UserManager<User> userManager)
        {
            _mesajRepository = mesajRepository;
            _userManager = userManager;
        }

        //Get: Mesaj
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _mesajRepository.FindAll().ToListAsync());
        }

        // GET: Mesaj/Create
        public IActionResult Create(int id)
        {
            MesajViewModel mesajVM = new MesajViewModel()
            {
                ForumID = id
            };
            return View(mesajVM);
        }

        // POST: Mesaj/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MesajViewModel mesajVM)
        {
            if (ModelState.IsValid)
            {
                Mesaj mesaj = new Mesaj()
                {
                    UserID = int.Parse(_userManager.GetUserId(User)),
                    ForumID = mesajVM.ForumID,
                    MesajScris = mesajVM.MesajScris,
                    Data = DateTime.Now
                };
                _mesajRepository.Create(mesaj);
                _mesajRepository.Save();
                return RedirectToAction(nameof(ForumController.Details), "Forum", new { id = mesaj.ForumID });
            }
            return View(mesajVM);
        }

        // GET: Mesaj/Edit/5
        /*public async Task<IActionResult> Edit(int id)
        {

            var mesaj = await _mesajRepository.FindByCondition(m => m.MesajID == id).FirstOrDefaultAsync();
            if (mesaj == null)
            {
                return NotFound();
            }
            MesajViewModel mesajVM = new MesajViewModel()
            {
                MesajID = mesaj.MesajID,
                UserID = mesaj.UserID,
                ForumID = mesaj.ForumID,
                MesajScris = mesaj.MesajScris
            };

            return View(mesajVM);
        }

        // POST: Mesaj/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MesajViewModel mesajVM)
        {
            if (ModelState.IsValid)
            {

                Mesaj mesaj = _mesajRepository.FindByCondition(m => m.MesajID == id).FirstOrDefault();

                if (mesaj == null)
                {
                    return NotFound();
                }

                //setting other values
                mesaj.MesajID = mesajVM.MesajID;
                mesaj.UserID = mesajVM.UserID;
                mesaj.ForumID = mesajVM.ForumID;
                mesaj.MesajScris = mesajVM.MesajScris;

                //success
                _mesajRepository.Update(mesaj);
                _mesajRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(mesajVM);
        }*/

        // GET: Mesaj/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesaj = _mesajRepository.FindByCondition(m => m.MesajID == id).FirstOrDefault();
            if (mesaj == null)
            {
                return NotFound();
            }

            _mesajRepository.Delete(mesaj);
            _mesajRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }

}
