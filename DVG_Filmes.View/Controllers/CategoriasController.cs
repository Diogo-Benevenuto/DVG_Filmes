using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DVG_FilmesWeb.Model;


namespace DVG_Filmes.View.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: CategoriasController
        VIDEO_LOCADORAContext odb;
        public CategoriasController()
        {
            odb = new VIDEO_LOCADORAContext();
        }

        public ActionResult Index()
        {
            List<Tbcategorias> oLista = odb.Tbcategorias.ToList();
            return View(oLista);
        }

        // GET: CategoriasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tbcategorias oCat)
        {
            odb.Tbcategorias.Add(oCat);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CategoriasController/Edit/5
        public ActionResult Edit(int id)
        {
            Tbcategorias oCat = odb.Tbcategorias.Find(id);
            return View(oCat);
        }

        // POST: CategoriasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tbcategorias oCat)
        {
            var oCatBanco = odb.Tbcategorias.Find(id);
            oCatBanco.Descricao = oCat.Descricao;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CategoriasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriasController/Delete/5
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

    internal class DVG_FilmesWebContext
    {
    }
}
