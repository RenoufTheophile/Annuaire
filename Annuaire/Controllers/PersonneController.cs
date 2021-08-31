using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Newtonsoft.Json;
using Annuaire.Data;
using Annuaire.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace Annuaire.Controllers
{
    public class PersonnesController : Controller
    {
        private readonly PersonneContext _context;
        private SqlConnection con;

        public PersonnesController(PersonneContext context)
        {
            _context = context;
        }

        // GET: Personnes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Personne.ToListAsync());
        }

        // GET: Personnes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personne = await _context.Personne
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personne == null)
            {
                return NotFound();
            }

            return View(personne);
        }

        // GET: Personnes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personnes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, last, first, phone, service, date")] Personne personne)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personne);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personne);
        }

        // GET: Personnes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personne = await _context.Personne.FindAsync(id);
            if (personne == null)
            {
                return NotFound();
            }
            return View(personne);
        }

        // POST: Personnes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, last, first, phone, service, date")] Personne personne)
        {
            if (id != personne.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personne);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonneExists(personne.Id))
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
            return View(personne);
        }

        // GET: Personnes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personne = await _context.Personne
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personne == null)
            {
                return NotFound();
            }

            return View(personne);
        }

        // POST: Personnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personne = await _context.Personne.FindAsync(id);
            _context.Personne.Remove(personne);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Ramdom()
        {
            var url = "https://randomuser.me/api/?inc=name,email,registered,phone";
            WebClient wc = new WebClient();
            var data = wc.DownloadString(url);
            var personne = JsonConvert.DeserializeObject<Root>(data);
            return View(personne);
        }
        public ActionResult AddPersonne()
        {

            return View();
        }
        //Post method to add details    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ramdom(Personne obj)
        {
            AddDetails(obj);

            return View();
        }
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlConn"].ToString();
            con = new SqlConnection(constr);

        }

        private void AddDetails(Personne obj)
        {
            connection();
            SqlCommand com = new SqlCommand("Personne2", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@last", obj.last);
            com.Parameters.AddWithValue("@first", obj.first);
            com.Parameters.AddWithValue("@date", obj.date);
            com.Parameters.AddWithValue("@phone", obj.phone);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        /*
        [HttpPost, ActionName("Ramdom")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ramdom([Bind("Id, first, last, date, phone, service ")] Personne personne)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personne);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personne);
        }
       */
        private bool PersonneExists(int id)
        {
            return _context.Personne.Any(e => e.Id == id);
        }
    }
}