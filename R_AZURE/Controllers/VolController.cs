using System;
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

        //Afficher vol par id
        [Route("VolDetail/{id}/{title}")]
        public IActionResult VolDetail(int id,string title)
        {
            ViewBag.VolId = id;
            ViewBag.VolTitle = title;
            return View();
        }

    }
}
