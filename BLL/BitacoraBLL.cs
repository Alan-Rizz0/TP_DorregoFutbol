using DAL;
using Servicios_Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BitacoraBLL
    {
        private BitacoraDAL bitacoraDAL = new BitacoraDAL();

        public bool RegistrarEvento(int idUsuario, string modulo, string evento, int criticidad)
        {
            BitacoraService nuevoEvento = new BitacoraService
            {
                Id_Usuario = idUsuario,
                Modulo = modulo,
                Evento = evento,
                Criticidad = criticidad
            };

            return bitacoraDAL.InsertarEvento(nuevoEvento);
        }

        public void LimpiarEventosViejos()
        {
            bitacoraDAL.LimpiarBitacoraVieja();
        }

        public DataTable ObtenerBitacora()
        {
            return bitacoraDAL.ListarBitacora();
        }

        public DataTable ObtenerBitacoraFiltrada(string nombre, string apellido, string username,string modulo,string evento, int? criticidad,DateTime? fechaInicio,DateTime? fechaFin)
        {
            return bitacoraDAL.ListarBitacoraFiltrada(nombre,apellido,username,modulo,evento,criticidad,fechaInicio,fechaFin);
        }
    }
}
