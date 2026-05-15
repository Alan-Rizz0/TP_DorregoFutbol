using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        Connection cn = new Connection();
        Mapper mapper = new Mapper();

        public UserBE SelectByUsername(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@Username", username)
           };


            DataTable dt = cn.Read("SPSelectByUser", parameters);

            if (dt.Rows.Count > 0)
            {
                return mapper.MapUser(dt.Rows[0]);
            }
            return null;
        }
    }
}
