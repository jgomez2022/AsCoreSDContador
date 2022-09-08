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
    public class ContadorController : Controller
    {
        private readonly LecturaContext _context;

        public ContadorController(LecturaContext context)
        {
            _context = context;
        }

        // GET: Contador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contadores.ToListAsync());
        }

        // GET: Contador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contador = await _context.Contadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contador == null)
            {
                return NotFound();
            }

            return View(contador);
        }

        // GET: Contador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numerocontador,Direccion,Tipo,Marca,Aplica_ts")] Contador contador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contador);
        }

        // GET: Contador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contador = await _context.Contadores.FindAsync(id);
            if (contador == null)
            {
                return NotFound();
            }
            return View(contador);
        }

        // POST: Contador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numerocontador,Direccion,Tipo,Marca,Aplica_ts")] Contador contador)
        {
            if (id != contador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContadorExists(contador.Id))
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
            return View(contador);
        }

        // GET: Contador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contador = await _context.Contadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contador == null)
            {
                return NotFound();
            }

            return View(contador);
        }

        // POST: Contador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contador = await _context.Contadores.FindAsync(id);
            _context.Contadores.Remove(contador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContadorExists(int id)
        {
            return _context.Contadores.Any(e => e.Id == id);
        }
    }
}
