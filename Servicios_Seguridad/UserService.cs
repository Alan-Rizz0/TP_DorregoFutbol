using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Seguridad
{
    public class UserService
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public bool Bloqueado { get; set; }
        public int IntentosFallido { get; set; }

        public int IdIdioma { get; set; }
    }
}
