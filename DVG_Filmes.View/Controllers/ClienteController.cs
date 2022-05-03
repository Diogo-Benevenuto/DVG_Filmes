using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DVG_FilmesWeb.Model;

namespace DVG_Filmes.View.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController

        VIDEO_LOCADORAContext odb;
        public ClienteController()
        {
            odb = new VIDEO_LOCADORAContext();
        }
        public ActionResult Index()
        {
            List<Tbclientes> oLista = odb.Tbclientes.ToList();
            return View(oLista);
           
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tbclientes oCat)
        {
            odb.Tbclientes.Add(oCat);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(String Documento)
        {
            Tbclientes oCat = odb.Tbclientes.Find(Documento);
            return View(oCat);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(String Documento, Tbclientes oCat)
        {
            var oCatBanco = odb.Tbclientes.Find();
            oCatBanco.Nome = oCat.Nome;
            oCatBanco.Email = oCat.Email;
            oCatBanco.Telefone = oCat.Telefone;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
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
