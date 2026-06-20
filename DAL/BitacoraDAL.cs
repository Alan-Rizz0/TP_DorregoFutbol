using Servicios_Seguridad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios_Seguridad;
using System.Data;

namespace DAL
{
    public class BitacoraDAL
    {
        Connection cn = new Connection();

        public bool InsertarEvento(BitacoraService evento)
        {
            if(evento.Criticidad<1 || evento.Criticidad>5) return false;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id_Usuario", evento.Id_Usuario),
                new SqlParameter("@Modulo", evento.Modulo),
                new SqlParameter("@Evento", evento.Evento),
                new SqlParameter("@Criticidad", evento.Criticidad)
            };

            return cn.Write("SPInsertarEventoBitacora", parameters);
        }


        public void LimpiarBitacoraVieja()
        {
            cn.Write("SPLimpiarBitacoraVieja", null);
        }

        public DataTable ListarBitacora()
        {
            return cn.Read("SPListarBitacora", null);
        }

        public DataTable ListarBitacoraFiltrada(string nombre,string apellido, string username, string modulo, string evento, int? criticidad, DateTime? fechaInicio, DateTime? fechaFin)
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Nombre", string.IsNullOrWhiteSpace(nombre) ? (object)DBNull.Value : nombre),
                new SqlParameter("@Apellido", string.IsNullOrWhiteSpace(apellido) ? (object)DBNull.Value : apellido),
                new SqlParameter("@Username", string.IsNullOrWhiteSpace(username) ? (object)DBNull.Value : username),
                new SqlParameter("@Modulo", string.IsNullOrWhiteSpace(modulo) ? (object)DBNull.Value : modulo),
                new SqlParameter("@Evento", string.IsNullOrWhiteSpace(evento) ? (object)DBNull.Value : evento),
                new SqlParameter("@Criticidad", criticidad.HasValue ? (object)criticidad.Value : DBNull.Value),
                new SqlParameter("@FechaInicio", fechaInicio.HasValue ? (object)fechaInicio.Value : DBNull.Value),
                new SqlParameter("@FechaFin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value)
                };

            return cn.Read("SPFiltrarBitacora", parametros);
        }
    }


}
