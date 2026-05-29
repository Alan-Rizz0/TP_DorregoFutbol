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
        private readonly UserDAL userDAL = new UserDAL();

        public bool Login(string username, string password)
        {
            UserService user = userDAL.SelectByUsername(username);

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

        public bool CambiarClave(UserService usuarioLogueado, string passActual, string passNueva, string passRepetida)
        {
            if (passNueva != passRepetida)
            {
                throw new Exception("Las nuevas contraseñas no coinciden.");
            }

            if (passNueva.Length < 8)
            {
                throw new Exception("La clave debe tener mínimo 8 caracteres.");
            }

            string hashActualIngresado = CryptoManager.EncryptString(passActual);
            if (usuarioLogueado.Password != hashActualIngresado)
            {
                throw new Exception("Contraseña actual errónea.");
            }

            string nuevoHash = CryptoManager.EncryptString(passNueva);

            return userDAL.UpdatePassword(usuarioLogueado.ID, nuevoHash);
        }
    }
}

/*
 * throw new Exception("EL HASH ES: " + InputHashed); para saber el hash
 */
