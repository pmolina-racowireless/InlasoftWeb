using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InlasoftWeb.Database;
using InlasoftWeb.Models;

namespace InlasoftWeb.Controllers
{
    public class CasosController : Controller
    {
        private readonly InlasoftDbContext _context;

        public CasosController(InlasoftDbContext context)
        {
            _context = context;    
        }

        // GET: Casos
        public async Task<IActionResult> Index()
        {
            var inlasoftDbContext = _context.Casos.Include(c => c.Cliente).Include(c => c.Firma).Include(c => c.Servicio);
            return View(await inlasoftDbContext.ToListAsync());
        }

        // GET: Casos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caso = await _context.Casos
                .Include(c => c.Cliente)
                .Include(c => c.Firma)
                .Include(c => c.Servicio)
                .SingleOrDefaultAsync(m => m.CasoId == id);
            if (caso == null)
            {
                return NotFound();
            }

            return View(caso);
        }

        // GET: Casos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId");
            ViewData["FirmaId"] = new SelectList(_context.Set<Firma>(), "FirmaId", "FirmaId");
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "ServicioId", "ServicioId");
            return View();
        }

        // POST: Casos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CasoId,ServicioId,FechaInicio,Descripcion,Contraparte,FirmaId,ClienteId,SucursalId,Catastro,Id,CreatedDate,LastModifiedDate,IsActive")] Caso caso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caso);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", caso.ClienteId);
            ViewData["FirmaId"] = new SelectList(_context.Set<Firma>(), "FirmaId", "FirmaId", caso.FirmaId);
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "ServicioId", "ServicioId", caso.ServicioId);
            return View(caso);
        }

        // GET: Casos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caso = await _context.Casos.SingleOrDefaultAsync(m => m.CasoId == id);
            if (caso == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", caso.ClienteId);
            ViewData["FirmaId"] = new SelectList(_context.Set<Firma>(), "FirmaId", "FirmaId", caso.FirmaId);
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "ServicioId", "ServicioId", caso.ServicioId);
            return View(caso);
        }

        // POST: Casos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CasoId,ServicioId,FechaInicio,Descripcion,Contraparte,FirmaId,ClienteId,SucursalId,Catastro,Id,CreatedDate,LastModifiedDate,IsActive")] Caso caso)
        {
            if (id != caso.CasoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasoExists(caso.CasoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", caso.ClienteId);
            ViewData["FirmaId"] = new SelectList(_context.Set<Firma>(), "FirmaId", "FirmaId", caso.FirmaId);
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "ServicioId", "ServicioId", caso.ServicioId);
            return View(caso);
        }

        // GET: Casos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caso = await _context.Casos
                .Include(c => c.Cliente)
                .Include(c => c.Firma)
                .Include(c => c.Servicio)
                .SingleOrDefaultAsync(m => m.CasoId == id);
            if (caso == null)
            {
                return NotFound();
            }

            return View(caso);
        }

        // POST: Casos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caso = await _context.Casos.SingleOrDefaultAsync(m => m.CasoId == id);
            _context.Casos.Remove(caso);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CasoExists(int id)
        {
            return _context.Casos.Any(e => e.CasoId == id);
        }
    }
}
