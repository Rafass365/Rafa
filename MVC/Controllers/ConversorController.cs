using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ConversorController : Controller

    {
        private readonly IConversorRepositorio _repositorio;

        public ConversorController(IConversorRepositorio repositorio) 
        {
            _repositorio = repositorio;
        }
        //Cada Metodo corresponde a una ruta

        // http://localhost:5000/Conversor/Index
        public IActionResult Index()
        {
            return View();
        }

        // http://localhost:5000/Conversor/Login
        public IActionResult Login()
        {
            return View(_repositorio.TraerTodasLasMonedas);
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
