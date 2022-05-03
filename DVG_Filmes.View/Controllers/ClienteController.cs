using Microsoft.AspNetCore.Mvc;
using DVG_Filmes.View.Models;


namespace DVG_Filmes.View.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadCliente (Cliente oCliente)
        {
            return View("DetalheCliente", oCliente);
        }

    }
}
