using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConversor_Interfaces
{
    
    public interface IEntidad
    {
        
        int Id { get; set; }
        DateTime FechaModificacion{ get; set; }
        DateTime FechaCreacion{ get; set; }
        string  QuienCreo{ get; set; }
        string QuienModifico{ get; set; }


    }
}
