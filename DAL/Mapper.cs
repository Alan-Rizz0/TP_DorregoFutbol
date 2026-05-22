
using Servicios_Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mapper
    {
        public UserService MapUser(DataRow row)
        {
            return new UserService()
            {
                ID = Convert.ToInt32(row["Id"]),
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                Nombre = row["Nombre"].ToString(),
                Apellido = row["Apellido"].ToString(),
                DNI = Convert.ToInt32(row["Dni"]),
                Bloqueado = Convert.ToBoolean(row["Bloqueado"])
            };
        }
    }
}
