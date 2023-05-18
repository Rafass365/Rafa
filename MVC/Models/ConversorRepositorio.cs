using EjemploConversor_Interfaces;

namespace MVC.Models
{
    public class ConversorRepositorio : IConversorRepositorio
    {

        public List<Moneda> TraerTodasLasMonedas => new List<Moneda>
        {
            new Moneda { Id = 1, Nombre="Euro", Simbolo = "EUR" },
            new Moneda {Id= 2, Nombre = "Dolar", Simbolo = "USD"},
            new Moneda {Id= 3, Nombre = "Libra", Simbolo = "GBP"}

        };

        public List<Usuario> TraerTodosLosUsuarios => new List<Usuario>
        {
            new Usuario { Id = 1, Nombre = "Juan"},
            new Usuario { Id = 2, Nombre = "Pepe"}
        };

        public List<Factor> TraerTodosLosFactores => new List<Factor>
        {
            new Factor{},
            new Factor{}

        };

        public List<Historico> TraerTodosLosHistoricos => new List<Historico> {

            new Historico{},
            new Historico{}
            };

    }
}
