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
    public class ForumController : Controller
    {
        private readonly IForumRepository _forumRepository;
        private readonly UserManager<User> _userManager;

        public ForumController(IForumRepository forumRepository, UserManager<User> userManager)
        {
            _forumRepository = forumRepository;
            _userManager = userManager;
        }

        //Get: Forum
        public async Task<IActionResult> Index()
        {
            return View(await _forumRepository.FindAll()
                .Include(f => f.Mesaje)
                .Include(f => f.User)
                .Select(f => new ForumViewModel() { 
                    DiscutieID = f.DiscutieID,
                    Nume = f.User.UserName,
                    Titlu = f.Titlu,
                    Data = f.Mesaje.OrderBy(m => m.Data).LastOrDefault() == null ? null : f.Mesaje.OrderBy(m => m.Data).LastOrDefault().Data
            }).ToListAsync());
        }

        // GET: Forum/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Forum/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ForumViewModel forumVM)
        {
            if (ModelState.IsValid)
            {
                Forum forum = new Forum()
                {
                    DiscutieID = forumVM.DiscutieID,
                    UserID = int.Parse(_userManager.GetUserId(User)),
                    Titlu = forumVM.Titlu,
                };
                _forumRepository.Create(forum);
                _forumRepository.Save();
                return RedirectToAction(nameof(Details), new { id = forum.DiscutieID });
            }
            return View(forumVM);
        }

        // GET: Forum/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var forum = await _forumRepository.FindByCondition(m => m.DiscutieID == id).FirstOrDefaultAsync();
            if (forum == null)
            {
                return NotFound();
            }
            ForumViewModel forumVM = new ForumViewModel()
            {
                DiscutieID = forum.DiscutieID,
                Nume = _userManager.GetUserName(User),
                Titlu = forum.Titlu,
            };

            return View(forumVM);
        }

        // POST: Forum/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ForumViewModel forumVM)
        {
            if (ModelState.IsValid)
            {

                Forum forum = _forumRepository.FindByCondition(m => m.DiscutieID == forumVM.DiscutieID).FirstOrDefault();

                if (forum == null)
                {
                    return NotFound();
                }

                //setting other values
                forum.DiscutieID = forumVM.DiscutieID;
                forum.Titlu = forumVM.Titlu;

                //success
                _forumRepository.Update(forum);
                _forumRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(forumVM);
        }

        public async Task<IActionResult> Details (int id)
        {

            var forum = await _forumRepository.FindByCondition(m => m.DiscutieID == id)
                .Include(f => f.Mesaje).ThenInclude(m => m.User)
                .FirstOrDefaultAsync();
            if (forum == null)
            {
                return NotFound();
            }
            

            return View(forum);
        }

        // GET: Forum/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forum = _forumRepository.FindByCondition(m => m.DiscutieID == id).FirstOrDefault();
            if (forum == null)
            {
                return NotFound();
            }

            _forumRepository.Delete(forum);
            _forumRepository.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
