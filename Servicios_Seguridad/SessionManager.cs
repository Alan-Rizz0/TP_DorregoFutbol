using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios_Seguridad
{
    public class SessionManager
    {
        private static object _lock = new object(); 
        private static SessionManager instance;

        public UserService Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        private SessionManager() { }

        public static SessionManager GetInstance //para obtener la instancia en cualquier lado
        {
            get
            {
                if (instance == null) throw new Exception("Sesión no iniciada");
                return instance;
            }
        }


        public static void Login(UserService usuario)
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new SessionManager();
                    instance.Usuario = usuario;
                    instance.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesion ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (instance != null)
                {
                    instance = null;
                }
                else
                {
                    throw new Exception("Sesion no iniciada");
                }
            }
        }

      
    }
}
