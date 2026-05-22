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
        private static SessionManager _session;

        public UserService Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        private SessionManager() { }

        public static SessionManager GetInstance //para obtener la instancia en cualquier lado
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");
                return _session;
            }
        }


        public static void Login(UserService usuario)
        {
            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesion ya iniciada");
                }
            }
        }

        public static void Logout(UserService usuario)
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesion no iniciada");
                }
            }
        }

        public static bool IsLoggedIn()
        {
            return _session != null;
        }
    }
}
