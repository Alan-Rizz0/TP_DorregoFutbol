using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Seguridad
{
    public class BitacoraService
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Modulo { get; set; }
        public string Evento { get; set; }
        public int Criticidad { get; set; }

        public string Username { get; set; }
    }
}
