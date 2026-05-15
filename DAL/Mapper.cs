using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;

namespace DAL
{
    public class Mapper
    {
        public UserBE MapUser(DataRow row)
        {
            return new UserBE()
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
