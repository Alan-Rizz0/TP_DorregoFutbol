using DAL;
using Servicios_Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        private readonly UserDAL userDAL = new UserDAL();



        public bool CrearUsuario(string username, string nombre, string apellido, int dni)
        {
            if (userDAL.ExisteUsername(username))
            {
                throw new Exception("El nombre de usuario ya existe en el sistema.");
            }
            string PasswordPlana = (nombre + dni).Replace(" ", "").ToLower(); //Replace(" ", "").ToLower()  xa sacar los espacios y que sea todo minuscula

            string PasswordHash = CryptoManager.EncryptString(PasswordPlana);

            return userDAL.InsertarUsuario(username, PasswordHash, nombre, apellido, dni);
        }
        public DataTable ObtenerTodosLosUsuarios()
        {
            return userDAL.ObtenerTodosLosUsuarios();
        }

        public bool Login(string username, string password)
        {
            
            UserService user = userDAL.SelectByUsername(username);

            if (user == null) throw new Exception("El usuario no existe. ");

            if (user.Bloqueado) throw new Exception("El usuario se encuentra bloqueado. ");

            string PasswordHash = CryptoManager.EncryptString(password);
            

            if (user.Password == PasswordHash)
            {
                if (user.IntentosFallido > 0)
                {
                    userDAL.ActualizarIntentos(username, 0, false);
                }

                SessionManager.Login(user);
                return true;
            }
            else
            {
                
                int nuevosIntentos = user.IntentosFallido + 1;
                bool debeBloquearse = nuevosIntentos >= 3;

                
                userDAL.ActualizarIntentos(username, nuevosIntentos, debeBloquearse);

                if (debeBloquearse)
                {
                    throw new Exception("La cuenta fue BLOQUEADA. Contacte al administrador.");
                }
                else
                {
                    
                    throw new Exception("La contraseña es incorrecta. Intentos fallidos: " + nuevosIntentos.ToString() + "/3");
                }
            }
        }

        public bool DesbloquearUsuario(int IDUsuario, string nombre, int dni)
        {
            string passwordplano = (nombre + dni).Replace(" ", "").ToLower();
            string passwordHash = CryptoManager.EncryptString(passwordplano);

            return userDAL.DesbloquearUsuario(IDUsuario, passwordHash);
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

            string PasswordHash = CryptoManager.EncryptString(passNueva);

            return userDAL.UpdatePassword(usuarioLogueado.ID, PasswordHash);
        }
    }
}

/*
 * throw new Exception("EL HASH ES: " + InputHashed); para saber el hash
 */
