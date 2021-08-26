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

        #region Attributs
        private MySqlConnection connexion; 
        private static string connectionString = "SERVER=127.0.0.1; DATABASE=annuaire ; UID=root; PASSWORD="; 
        #endregion
    }
}
