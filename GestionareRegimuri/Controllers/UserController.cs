using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using GestionareRegimuri.Data;
using GestionareRegimuri.Models;
using GestionareRegimuri.ViewModels;
using GestionareRegimuri.Utils.Services;
using GestionareRegimuri.Repository.Interfaces;

namespace GestionareRegimuri.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IBoalaService _boalaService;
        private readonly IUserRepository _userRepository;

        public UserController(ApplicationDbContext context, UserManager<User> userManager, IBoalaService boalaService, IUserRepository userRepository)
        {
            _context = context;
            _userManager = userManager;
            _boalaService = boalaService;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details()
        {
            int id = int.Parse(_userManager.GetUserId(User));
            var user = _userRepository.FindByCondition(u => u.Id == id).Include(u => u.Boli).SingleOrDefault();

            return View(new UserViewModel()
            {
                Email = user.Email,
                Username = user.UserName,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
                Boli = _boalaService.stringifyBoalas(user.Boli)
            });
        }

        public async Task<IActionResult> Edit()
        {
            int id = int.Parse(_userManager.GetUserId(User));
            var user = _userRepository.FindByCondition(u => u.Id == id).Include(u => u.Boli).SingleOrDefault();

            return View(new UserViewModel()
            {
                Email = user.Email,
                Username = user.UserName,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
                Boli = _boalaService.stringifyBoalas(user.Boli)
            });
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(UserViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                //Check current password
                if (!await _userManager.CheckPasswordAsync(user, userVM.CurrentPassword))
                {
                    ModelState.AddModelError(nameof(UserViewModel.CurrentPassword), "Wrong password");
                    goto fail;
                }

                //Do we have a new password?
                if (!string.IsNullOrEmpty(userVM.Password))
                {
                    var passResult = await _userManager.ChangePasswordAsync(user, userVM.CurrentPassword, userVM.Password);
                    if (!passResult.Succeeded)
                    {
                        foreach (var err in passResult.Errors)
                        {
                            ModelState.AddModelError(nameof(UserViewModel.Password), err.Description);
                        }
                        goto fail;
                    }

                    //updating and checking if we failed
                    if (!await updateDetails(user, userVM))
                    {
                        //force reload from the database!!!
                        _userRepository.Reload(user);

                        var passResult2 = await _userManager.ChangePasswordAsync(user, userVM.Password, userVM.CurrentPassword);
                        if (!passResult2.Succeeded)
                        {
                            foreach (var err in passResult.Errors)
                            {
                                ModelState.AddModelError(String.Empty, err.Description);
                            }
                            goto fail;
                        }
                        goto fail;
                    }
                }
                //updating without new password
                else
                {
                    if (!await updateDetails(user, userVM))
                    {
                        goto fail;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
        fail:
            return View(userVM);
        }

        async Task<bool> updateDetails(User user, UserViewModel userVM)
        {
            _userRepository.LoadCollection(user, u => u.Boli);

            user.Boli = _boalaService.parseBoalas(userVM.Boli);
            user.Email = userVM.Email;
            user.UserName = userVM.Username;
            user.Name = userVM.Name;
            user.PhoneNumber = userVM.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, err.Description);
                }
                return false;
            }
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
