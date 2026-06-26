
using Servicios_Seguridad;
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


        public bool InsertarUsuario(string username, string password, string nombre, string apellido, int dni)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Apellido", apellido),
                new SqlParameter("@DNI", dni)
            };

            return cn.Write("SPInsertarUsuario", parameters);
        }
        public DataTable ObtenerTodosLosUsuarios()
        {
            return cn.Read("SPObtenerTodosLosUsuarios", null);
        }

        public bool ExisteUsername(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
            };

            DataTable dt = cn.Read("SPExisteUsuario", parameters);
            return dt.Rows.Count > 0;
        }



        public UserService SelectByUsername(string username)
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

        public bool UpdatePassword(int IDUsuario, string NewHash)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@iD", IDUsuario),
                new SqlParameter("@Password", NewHash)
            };

            return cn.Write("SPUpdatePassword", parameters);
        }

        public bool ActualizarIntentos(string username, int intentos, bool bloqueado)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@IntentosFallidos", intentos),
                new SqlParameter("@Bloqueado", bloqueado)
            };

            return cn.Write("SPActualizarIntentosLogin", parameters);
        }
        public bool DesbloquearUsuario(int IDUsuario, string NuevoPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", IDUsuario),
                new SqlParameter("@Password", NuevoPassword)
            };

            return cn.Write("SPDesbloquearUsuario", parameters);
        }

        public bool CambiarEstadoActivo(int IDUsuario, bool Bloqueado)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", IDUsuario),
                new SqlParameter("@Bloqueado", Bloqueado)
            };

            return cn.Write("SPCambiarEstadoActivoUsuario", parameters);
        }


        public bool ActualizarIdiomaUsuario(int idUsuario, int idIdioma)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", idUsuario),
                new SqlParameter("@IDIdioma", idIdioma)
            };

            return cn.Write("SPActualizarIdiomaUsuario", parameters);
        }
    }
}
