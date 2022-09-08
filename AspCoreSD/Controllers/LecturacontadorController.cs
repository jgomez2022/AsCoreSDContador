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
    public class LecturacontadorController : Controller
    {
        private readonly LecturaContext _context;

        public LecturacontadorController(LecturaContext context)
        {
            _context = context;
        }

        // GET: Lecturacontador
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.Lecturacontadors.ToListAsync());
            
        }

   

        // GET: Lecturacontador/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Lecturacontador());
            else
                return View(_context.Lecturacontadors.Find(id));
        }

        // POST: Lecturacontador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Contador,Lectura,Fecha")] Lecturacontador lecturacontador)
        {
            if (ModelState.IsValid)
            {
                if (lecturacontador.Id == 0)
                    _context.Add(lecturacontador);
                else
                    _context.Update(lecturacontador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lecturacontador);
        }



        // GET: Lecturacontador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var lecturacontador = await _context.Lecturacontadors.FindAsync(id);
            _context.Lecturacontadors.Remove(lecturacontador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
