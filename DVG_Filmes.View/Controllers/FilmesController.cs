using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DVG_Filmes.View.Controllers
{
    public class FilmesController : Controller
    {
        // GET: FilmesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FilmesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FilmesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FilmesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
