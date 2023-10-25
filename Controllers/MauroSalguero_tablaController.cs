using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MauroSalguero_1P.Data;
using MauroSalguero_1P.Models;

namespace MauroSalguero_1P.Controllers
{
    public class MauroSalguero_tablaController : Controller
    {
        private readonly MauroSalguero_1PContext _context;

        public MauroSalguero_tablaController(MauroSalguero_1PContext context)
        {
            _context = context;
        }

        // GET: MauroSalguero_tabla
        public async Task<IActionResult> Index()
        {
              return _context.MauroSalguero_tabla != null ? 
                          View(await _context.MauroSalguero_tabla.ToListAsync()) :
                          Problem("Entity set 'MauroSalguero_1PContext.MauroSalguero_tabla'  is null.");
        }

        // GET: MauroSalguero_tabla/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.MauroSalguero_tabla == null)
            {
                return NotFound();
            }

            var mauroSalguero_tabla = await _context.MauroSalguero_tabla
                .FirstOrDefaultAsync(m => m.msName == id);
            if (mauroSalguero_tabla == null)
            {
                return NotFound();
            }

            return View(mauroSalguero_tabla);
        }

        // GET: MauroSalguero_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MauroSalguero_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("msName,msID,msUdlaStudent,msEdad,msDateOfBirth,msGrade")] MauroSalguero_tabla mauroSalguero_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mauroSalguero_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mauroSalguero_tabla);
        }

        // GET: MauroSalguero_tabla/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.MauroSalguero_tabla == null)
            {
                return NotFound();
            }

            var mauroSalguero_tabla = await _context.MauroSalguero_tabla.FindAsync(id);
            if (mauroSalguero_tabla == null)
            {
                return NotFound();
            }
            return View(mauroSalguero_tabla);
        }

        // POST: MauroSalguero_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("msName,msID,msUdlaStudent,msEdad,msDateOfBirth,msGrade")] MauroSalguero_tabla mauroSalguero_tabla)
        {
            if (id != mauroSalguero_tabla.msName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mauroSalguero_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MauroSalguero_tablaExists(mauroSalguero_tabla.msName))
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
            return View(mauroSalguero_tabla);
        }

        // GET: MauroSalguero_tabla/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.MauroSalguero_tabla == null)
            {
                return NotFound();
            }

            var mauroSalguero_tabla = await _context.MauroSalguero_tabla
                .FirstOrDefaultAsync(m => m.msName == id);
            if (mauroSalguero_tabla == null)
            {
                return NotFound();
            }

            return View(mauroSalguero_tabla);
        }

        // POST: MauroSalguero_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.MauroSalguero_tabla == null)
            {
                return Problem("Entity set 'MauroSalguero_1PContext.MauroSalguero_tabla'  is null.");
            }
            var mauroSalguero_tabla = await _context.MauroSalguero_tabla.FindAsync(id);
            if (mauroSalguero_tabla != null)
            {
                _context.MauroSalguero_tabla.Remove(mauroSalguero_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MauroSalguero_tablaExists(string id)
        {
          return (_context.MauroSalguero_tabla?.Any(e => e.msName == id)).GetValueOrDefault();
        }
    }
}
