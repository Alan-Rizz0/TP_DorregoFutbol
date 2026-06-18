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
    }


}
