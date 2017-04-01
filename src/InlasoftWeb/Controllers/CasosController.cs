using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InlasoftWeb.Database;
using InlasoftWeb.Models;
using InlasoftWeb.Extensions;
using Microsoft.AspNetCore.Identity;
using System;
using InlasoftWeb.ViewModels;

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
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var userFirmaId = User.Identity.GetFirmaId();
            var caso = GetCasosByFirmaId(userFirmaId);

            #region Table Sorting
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["IdSortParm"] = sortOrder == "id" ? "id_desc" : "id";
            switch (sortOrder)
            {
                case "name_desc":
                    caso = caso.OrderByDescending(c => c.Descripcion);
                    break;
                case "id":
                    caso = caso.OrderBy(c => c.CasoId);
                    break;
                case "id_desc":
                    caso = caso.OrderByDescending(c => c.CasoId);
                    break;
                default:
                    caso = caso.OrderBy(c => c.Descripcion);
                    break;
            }
            #endregion

            #region Table Filtering
            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                caso = caso.Where(c => c.Descripcion.Contains(searchString));

            }

            #endregion

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
            var caso = GetCasosByFirmaIdAndCasoId(userFirmaId, id);
            if (caso == null)
            {
                return NotFound();
            }
            return View(await caso.AsNoTracking().SingleOrDefaultAsync());
        }

        private IQueryable<CasoViewModel> GetCasosByFirmaId(string firmaId)
        {
            var caso = _context.Casos
                .Include(c => c.Servicio)
                    .ThenInclude(s => s.Materia)
                .Include(c => c.Cliente)
                .Include(c => c.Sucursal)
                .Include(c => c.Firma)
                .Where(c => c.Firma.FirmaId == firmaId)
                .Select(x => (CasoViewModel)x);
            return caso;
        }

        private IQueryable<CasoViewModel> GetCasosByFirmaIdAndCasoId(string firmaId, string casoId)
        {
            var caso = _context.Casos
                .Include(c => c.Servicio)
                    .ThenInclude(s => s.Materia)
                .Include(c => c.Cliente)
                .Include(c => c.Sucursal)
                .Include(c => c.Firma)
                .Where(c => c.Firma.FirmaId == firmaId && c.CasoId == casoId)
                .Select(x => (CasoViewModel)x);
            return caso;
        }

    }
}
