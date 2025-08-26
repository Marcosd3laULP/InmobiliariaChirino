using Microsoft.AspNetCore.Mvc;
using inmobiliaria25.Models;

namespace inmobiliaria25.Controllers
{
    public class InquilinosController : Controller
    {
        private readonly InmobiliariaContext _context;

        public InquilinosController(InmobiliariaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var inquilinos = _context.Inquilinos.ToList();
            return View(inquilinos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Inquilino inquilino)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquilino);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(inquilino);
        }

        public IActionResult Details(int id)
        {
            var inquilino = _context.Inquilinos.FirstOrDefault(p => p.Id == id);
            if (inquilino == null)
            {
                return NotFound();
            }
            return View(inquilino);
        }

        public IActionResult Edit(int id)
        {
            var inquilino = _context.Inquilinos.Find(id);
            if (inquilino == null)
            {
                return NotFound();
            }
            return View(inquilino);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Inquilino inquilino)
        {
            if (id != inquilino.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(inquilino);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(inquilino);
        }

        public IActionResult Delete(int id)
        {
            var inquilino = _context.Inquilinos.Find(id);
            if (inquilino == null)
            {
                return NotFound();
            }
            return View(inquilino);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var inquilino = _context.Inquilinos.Find(id);
            if (inquilino != null)
            {
                _context.Inquilinos.Remove(inquilino);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }        
    }
}