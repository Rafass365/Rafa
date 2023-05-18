using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            var mayordomo = new ConversorRepositorio();
            var ListaMonedas = mayordomo.TraerTodasLasMonedas;
            var ListaUsuario = mayordomo.TraerTodosLosUsuarios;
            var ListaFactores = mayordomo.TraerTodosLosFactores;
            var ListaHistoricos = mayordomo.TraerTodosLosHistoricos;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}