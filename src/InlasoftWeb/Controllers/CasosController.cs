using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InlasoftWeb.Database;
using InlasoftWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace InlasoftWeb.Controllers
{
    public class CasosController : Controller
    {
        private readonly InlasoftDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public CasosController(InlasoftDbContext context, UserManager<ApplicationUser> userManager,
          SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Casos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casos.Include(casos => casos.Servicio).ToListAsync());
        }

        // GET: Casos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caso = await _context.Casos
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
            return View();
        }

        // POST: Casos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CasoId,FechaInicio,Descripcion,Contraparte,Catastro,CreatedDate,LastModifiedDate,IsActive")] Caso caso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caso);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(caso);
        }

        // GET: Casos/Edit/5
        public async Task<IActionResult> Edit(string id)
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
            return View(caso);
        }

        // POST: Casos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CasoId,FechaInicio,Descripcion,Contraparte,Catastro,CreatedDate,LastModifiedDate,IsActive")] Caso caso)
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
            return View(caso);
        }

        // GET: Casos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caso = await _context.Casos
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
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var caso = await _context.Casos.SingleOrDefaultAsync(m => m.CasoId == id);
            _context.Casos.Remove(caso);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CasoExists(string id)
        {
            return _context.Casos.Any(e => e.CasoId == id);
        }
    }
}
