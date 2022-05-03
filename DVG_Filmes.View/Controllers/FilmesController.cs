using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DVG_FilmesWeb.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DVG_Filmes.View.Controllers
{
    public class FilmesController : Controller
    {
        // GET: FilmesController
        VIDEO_LOCADORAContext odb;

        public FilmesController()
        {   
            odb = new VIDEO_LOCADORAContext();
        }

        public ActionResult Index()
        {
            var retorno = odb.Tbfilmes.Include(e => e.IdCategoriaNavigation).AsNoTracking(); 
            return View(retorno);
        }

        // GET: FilmesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FilmesController/Create
        public ActionResult Create()
        {
            var Lista = new SelectList(odb.Tbcategorias.ToList(), "Id", "Descricao");
            ViewBag.IdCategoria = Lista;
            return View();
        }

        // POST: FilmesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tbfilmes oFilmes)
        {
            try
            {
                odb.Tbfilmes.Add(oFilmes);
                odb.SaveChanges();
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
            Tbfilmes oFilmes = odb.Tbfilmes.Find(id);
            var Lista = new SelectList(odb.Tbcategorias.ToList(), "Id", "Descricao", oFilmes.IdCategoria);
            ViewBag.IdCategoria = Lista;
            return View(oFilmes);
        }

        // POST: FilmesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tbfilmes oFilmes)
        {
            odb.Entry(oFilmes).State = EntityState.Modified;
            odb.SaveChanges();
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
            Tbfilmes oFilmes = odb.Tbfilmes.Find(id);
            odb.Entry(oFilmes).State = EntityState.Deleted;
            odb.SaveChanges();
            return RedirectToAction(nameof(Index));
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
