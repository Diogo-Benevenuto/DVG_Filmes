using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DVG_FilmesWeb.Model;
using Microsoft.EntityFrameworkCore;

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
            List<Tbcliente> oLista = odb.Tbcliente.ToList();
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
        public ActionResult Create(Tbcliente oCat)
        {
            odb.Tbcliente.Add(oCat);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            Tbcliente oCat = odb.Tbcliente.Find(id);
            return View(oCat);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tbcliente oCat)
        {
            var oCatBanco = odb.Tbcliente.Find(id);
            oCatBanco.Nome = oCat.Nome;
            oCatBanco.Telefone = oCat.Telefone;
            oCatBanco.Cpf = oCat.Cpf;
            oCatBanco.Email = oCat.Email;
            odb.Entry(oCatBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            Tbcliente oCat = odb.Tbcliente.Find(id);
            var oCatBanco = odb.Tbcliente.Find(id);
            odb.Entry(oCatBanco).State =EntityState.Deleted;
            odb.SaveChanges();
            return RedirectToAction("Index");
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
