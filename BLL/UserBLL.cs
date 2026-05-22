using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Servicios_Seguridad;

namespace BLL
{
    public class UserBLL
    {
        private readonly UserDAL dataAccess = new UserDAL();

        public bool Login(string username, string password)
        {
            UserService user = dataAccess.SelectByUsername(username);

            if (user == null) throw new Exception("El usuario no existe. ");

            if (user.Bloqueado) throw new Exception("El usuario se encuentra bloqueado. ");

            string InputHashed = CryptoManager.EncryptString(password);
            

            if (user.Password == InputHashed)
            {
                SessionManager.Login(user);
                return true;
            }
            else
            {
                throw new Exception("La contraseña es incorrecta. ");
            }
        }
    }
}

/*
 * throw new Exception("EL HASH ES: " + InputHashed); para saber el hash
 */
