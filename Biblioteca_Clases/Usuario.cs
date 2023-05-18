using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConversor_Interfaces
{
    public class Usuario : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }  
        public EmailAddressAttribute Email { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string Pais { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string QuienCreo { get; set; }
        public string QuienModifico { get; set; }
      
    }
}
