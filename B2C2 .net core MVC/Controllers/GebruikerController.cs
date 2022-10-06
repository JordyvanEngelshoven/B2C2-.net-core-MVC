using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using B2C2_.net_core_MVC.Controllers.Data;
using B2C2_.net_core_MVC.Models;

namespace B2C2_.net_core_MVC.Controllers
{
    public class GebruikerController : Controller
    {
        private readonly AppDbContext _context;

        public GebruikerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Gebruiker
        public async Task<IActionResult> Index()
        {
              return View(await _context.Gebruikers.ToListAsync());
        }

        // GET: Gebruiker/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Gebruikers == null)
            {
                return NotFound();
            }

            var gebruiker = await _context.Gebruikers
                .FirstOrDefaultAsync(m => m.GebruikerID == id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // GET: Gebruiker/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gebruiker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GebruikerID,GebruikerNaam,AanmaakDatum,GeboorteDatum,Wachtwoord,EmailAdres")] Gebruiker gebruiker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gebruiker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gebruiker);
        }

        // GET: Gebruiker/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Gebruikers == null)
            {
                return NotFound();
            }

            var gebruiker = await _context.Gebruikers.FindAsync(id);
            if (gebruiker == null)
            {
                return NotFound();
            }
            return View(gebruiker);
        }

        // POST: Gebruiker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GebruikerID,GebruikerNaam,AanmaakDatum,GeboorteDatum,Wachtwoord,EmailAdres")] Gebruiker gebruiker)
        {
            if (id != gebruiker.GebruikerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gebruiker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GebruikerExists(gebruiker.GebruikerID))
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
            return View(gebruiker);
        }

        // GET: Gebruiker/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Gebruikers == null)
            {
                return NotFound();
            }

            var gebruiker = await _context.Gebruikers
                .FirstOrDefaultAsync(m => m.GebruikerID == id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // POST: Gebruiker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Gebruikers == null)
            {
                return Problem("Entity set 'AppDbContext.Gebruikers'  is null.");
            }
            var gebruiker = await _context.Gebruikers.FindAsync(id);
            if (gebruiker != null)
            {
                _context.Gebruikers.Remove(gebruiker);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GebruikerExists(int id)
        {
          return _context.Gebruikers.Any(e => e.GebruikerID == id);
        }
    }
}
