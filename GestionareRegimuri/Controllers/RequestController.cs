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
using GestionareRegimuri.ViewModels;
using Microsoft.AspNetCore.Identity;
using GestionareRegimuri.Repository.Interfaces;

namespace GestionareRegimuri.Controllers
{
    [Authorize]
    public class RequestController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
