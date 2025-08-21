using Microsoft.AspNetCore.Mvc;
using inmobiliaria25.Models;

namespace inmobiliaria25.Controllers
{


    public class PropietarioController : Controller
    {

        private readonly InmobiliariaContext _context;

         public PropietarioController(InmobiliariaContext _context)
         {
             _context = context;
         }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Persona propietario)
        {
            if (ModelState.IsValid)
            {
                _context.Propiertario.add(propietario);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propietario);
        }

        public IActionResult Index()
        {
            var lista = _context.Propietario.ToList();
            return View(lista);
        }
    }

}