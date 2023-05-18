

namespace EjemploConversor_Interfaces
{
    public class Moneda : IEntidad
    {
        public int  Id { get; set; }
        public string Nombre  { get; set; }
        public string Simbolo { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string QuienCreo { get; set; }
        public string QuienModifico { get; set; }
        
    }
}
