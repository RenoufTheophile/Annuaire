using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace Annuaire.Controllers
{
    public class ManagerPerson : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
