using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConversor_Interfaces
{
    public class Historico : IEntidad

    {
        
        public Moneda MonedaOrigen { get; set; }
        public Moneda MonedaDestino { get; set; }
        public int FactorConversor { get; set; }
        public int Cantidad { get; set; }
        public DateOnly FechaConversion { get; set; }
        public Usuario Usuario { get; set; }
               
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public  string QuienCreo { get; set; }
        public int Id { get; set; }
        string QuienModifico { get; set; }
        string IEntidad.QuienModifico { get; set; }
    }
}
