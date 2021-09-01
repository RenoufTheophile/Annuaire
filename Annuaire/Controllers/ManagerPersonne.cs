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
        

        public PersonnesController(PersonneContext context)
        {
            _context = context;
        }

        // GET: Personnes
        public async Task<IActionResult> Index(string searchString)
        {
            var personnes = from m in _context.Personne
                            select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                personnes = personnes.Where(s => s.Last.Contains(searchString));
            }
            return View(await personnes.ToListAsync());
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
        public async Task<IActionResult> Create( Personne personne)
        {
            if (ModelState.IsValid)
            {
                Personne personnes = new()
                {
                    Last = personne.Last,
                    First = personne.First,
                    Date = personne.Date,
                    Phone = personne.Phone,
                    Service = personne.Service
                };
                _context.Add(personnes);
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
        public async Task<IActionResult> Edit(int id,Personne personne)
        {
            if (id != personne.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Personne personnes = new()
                    {
                        Last = personne.Last,
                        First = personne.First,
                        Date = personne.Date,
                        Phone = personne.Phone,
                        Service = personne.Service
                    };
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
            WebClient wc = new();
            var data = wc.DownloadString(url);
            var personne = JsonConvert.DeserializeObject<Personne>(data);
            if (personne == null)
            {
                return NotFound();
            }
            return View(personne);
        }
        
       
        [HttpPost, ActionName("Ramdom")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ramdom( Personne personne)
        {
            if (ModelState.IsValid)
            {
                var url = "https://randomuser.me/api/?inc=name,email,registered,phone";
                WebClient wc = new();
                var data = wc.DownloadString(url);
                var personness = JsonConvert.DeserializeObject<Personne>(data);
                Personne personnes = new()
                {
                    Last = personness.Results[0].Name.Last,
                    First = personness.Results[0].Name.First,
                    Date=personness.Results[0].Registered.Date,
                    Phone=personness.Results[0].Phone,
                    Service=personne.Service
                };
               
                _context.Add(personnes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(personne);
        }
       
        private bool PersonneExists(int id)
        {
            return _context.Personne.Any(e => e.Id == id);
        }
    }
}