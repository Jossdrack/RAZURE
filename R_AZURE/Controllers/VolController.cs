﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace R_AZURE.Controllers
{
    public class VolController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lire()
        {
            return View();
        }

        public IActionResult Lire(int id)
        {
            ViewBag.VolId = id;
            return View();
        }

    }
}