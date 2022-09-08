using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspCoreSD.Models;

namespace AspCoreSD.Controllers
{
    public class ContadoresclienteController : Controller
    {
        private readonly LecturaContext _context;

        public ContadoresclienteController(LecturaContext context)
        {
            _context = context;
        }

        // GET: Contadorescliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contadoresclientes.ToListAsync());
        }

        // GET: Contadorescliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contadorescliente = await _context.Contadoresclientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contadorescliente == null)
            {
                return NotFound();
            }

            return View(contadorescliente);
        }

        // GET: Contadorescliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contadorescliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,IdContador")] Contadorescliente contadorescliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contadorescliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contadorescliente);
        }

        // GET: Contadorescliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contadorescliente = await _context.Contadoresclientes.FindAsync(id);
            if (contadorescliente == null)
            {
                return NotFound();
            }
            return View(contadorescliente);
        }

        // POST: Contadorescliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,IdContador")] Contadorescliente contadorescliente)
        {
            if (id != contadorescliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contadorescliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContadoresclienteExists(contadorescliente.Id))
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
            return View(contadorescliente);
        }

        // GET: Contadorescliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contadorescliente = await _context.Contadoresclientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contadorescliente == null)
            {
                return NotFound();
            }

            return View(contadorescliente);
        }

        // POST: Contadorescliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contadorescliente = await _context.Contadoresclientes.FindAsync(id);
            _context.Contadoresclientes.Remove(contadorescliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContadoresclienteExists(int id)
        {
            return _context.Contadoresclientes.Any(e => e.Id == id);
        }
    }
}
