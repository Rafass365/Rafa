using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConversor_Interfaces
{
    public class Factor
    {
        public Moneda MonedaOrigen { get; set; }
        public Moneda MonedaDestino { get; set; }
        public int  FactorConversor { get; set; }
    }
}
