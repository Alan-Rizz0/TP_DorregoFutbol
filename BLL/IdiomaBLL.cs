using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IdiomaBLL
    {
        private IdiomaDAL idiomaDAL = new IdiomaDAL();

        public DataTable ObtenerIdiomas()
        {
            return idiomaDAL.SeleccionarIdiomas();
        }

        public DataTable ObtenerTraducciones(int IDIdiomas)
        {
            return idiomaDAL.SeleccionarTraduccion(IDIdiomas);
        }


    }
}
