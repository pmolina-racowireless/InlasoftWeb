using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InlasoftWeb.Database;
using InlasoftWeb.Models;
using InlasoftWeb.Extensions;
using Microsoft.AspNetCore.Identity;
using System;

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
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            var userFirmaId = User.Identity.GetFirmaId();
            var caso = _context.Casos
                .Include(casos => casos.Servicio)
                    .ThenInclude(servicio => servicio.Materia)
                .Include(casos => casos.Cliente)
                .Include(casos => casos.Sucursal)
                .Where(casos => casos.Firma.FirmaId == userFirmaId);

            switch (sortOrder)
            {
                case "name_desc":
                    caso = caso.OrderByDescending(c => c.Descripcion);
                    break;
                case "Date":
                    caso = caso.OrderBy(s => s.FechaInicio);
                    break;
                case "date_desc":
                    caso = caso.OrderByDescending(s => s.FechaInicio);
                    break;
                default:
                    caso = caso.OrderBy(s => s.Descripcion);
                    break;
            }
            return View(await caso.AsNoTracking().ToListAsync());
        }

        // GET: Casos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFirmaId = User.Identity.GetFirmaId();
            var caso = await _context.Casos
                .Include(casos => casos.Servicio)
                    .ThenInclude(servicio => servicio.Materia)
                .Include(casos => casos.Cliente)
                .Include(casos => casos.Sucursal)
                .SingleOrDefaultAsync(m => m.CasoId == id && m.Firma.FirmaId == userFirmaId);
            if (caso == null)
            {
                return NotFound();
            }

            return View(caso);
        }

    }
}
