using EjemploConversor_Interfaces;

namespace MVC.Models
{
    public interface IConversorRepositorio
    {

        // Traer todas las monedas
        List<Moneda> TraerTodasLasMonedas { get; }

        // Traer todos los usuarios

        List<Usuario> TraerTodosLosUsuarios { get; }

        // Traer todos los factores de conversion
        List<Factor> TraerTodosLosFactores { get; }

        // Traer el histórico de conversiones
        List<Historico> TraerTodosLosHistoricos { get; }


        // Agregar nueva conversion al historico de conversiones
        // Agregar nuevo usuario
        // Login
        // Agregar nueva moneda
        // Borrar moneda
        // Borrar usuario
        // Borrar una entrada del historico

    }
}
