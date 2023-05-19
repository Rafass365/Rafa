using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {//Para Poder guardar todo lo que recibamos por el controlador en variables
        private readonly ILogger<HomeController> _logger;
        private readonly ITest _test;
        private readonly IConversorRepositorio _conversorRepositorio;

        public HomeController(ILogger<HomeController> logger,
                               ITest test, IConversorRepositorio repositorio)
        {

            _logger = logger;
            _test = test;
            _conversorRepositorio = repositorio;
        }

        public IActionResult Index()


        {
            var mayordomo = new ConversorRepositorio();
            // var ListaMonedas = mayordomo.TraerTodasLasMonedas;
            // var ListaUsuario = mayordomo.TraerTodosLosUsuarios;
            // var ListaFactores = mayordomo.TraerTodosLosFactores;
            // var ListaHistoricos = mayordomo.TraerTodosLosHistoricos;
            ViewBag.ListaMonedas = _conversorRepositorio.TraerTodasLasMonedas;
            //ViewBag.ListaUsuarios = _conversorRepositorio.TraerTodosLosUsuarios;
            //ViewBag.ListaFactores = _conversorRepositorio.TraerTodosLosFactores;
            //ViewBag.ListaHistoricos = _conversorRepositorio.TraerTodosLosHistoricos;
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
