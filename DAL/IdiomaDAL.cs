using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class IdiomaDAL
    {
        Connection cn = new Connection();

        public DataTable SeleccionarIdiomas()
        {
            return cn.Read("SP_SeleccionarIdiomas", null);
        }

        public DataTable SeleccionarTraduccion(int IDIdioma)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@IDIdioma", IDIdioma),
            };

            return cn.Read("SP_ObtenerTraducciones", parameters);
        }
    }
}
