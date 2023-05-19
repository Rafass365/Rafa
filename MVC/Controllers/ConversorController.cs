using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ConversorController : Controller
    {
        //Cada Metodo corresponde a una ruta

        // http://localhost:5000/Conversor/Index
        public IActionResult Index()
        {
            return View();
        }

        // http://localhost:5000/Conversor/Login
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult ListaMonedas()
        {
            return View();
        }

        public IActionResult EditorMoneda()
        {
            return View();
        }
    }
}
