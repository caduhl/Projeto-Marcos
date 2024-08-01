using Microsoft.AspNetCore.Mvc;

namespace AtividadeMarcos.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
