using Microsoft.AspNetCore.Mvc;
using inmobiliaria25.Models;

namespace inmobiliaria25.Controllers
{
    public class PropietariosController : Controller
    {
        private readonly InmobiliariaContext _context;

        // Inyección de dependencias: se recibe el DbContext
        public PropietariosController(InmobiliariaContext context)
        {
            _context = context;
        }

        // GET: Propietarios
        public IActionResult Index()
        {
            var propietarios = _context.Propietarios.ToList();
            return View(propietarios);
        }

        // GET: Propietarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propietarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Propietario propietario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propietario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(propietario);
        }

        // GET: Propietarios/Details/5
        public IActionResult Details(int id)
        {
            var propietario = _context.Propietarios.FirstOrDefault(p => p.id == id);
            if (propietario == null)
            {
                return NotFound();
            }
            return View(propietario);
        }

        // GET: Propietarios/Edit/5
        public IActionResult Edit(int id)
        {
            var propietario = _context.Propietarios.Find(id);
            if (propietario == null)
            {
                return NotFound();
            }
            return View(propietario);
        }

        // POST: Propietarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Propietario propietario)
        {
            if (id != propietario.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(propietario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(propietario);
        }

        // GET: Propietarios/Delete/5
        public IActionResult Delete(int id)
        {
            var propietario = _context.Propietarios.Find(id);
            if (propietario == null)
            {
                return NotFound();
            }
            return View(propietario);
        }

        // POST: Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var propietario = _context.Propietarios.Find(id);
            if (propietario != null)
            {
                _context.Propietarios.Remove(propietario);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
