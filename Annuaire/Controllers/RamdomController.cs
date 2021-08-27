using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annuaire.Controllers
{
    public class RamdomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
