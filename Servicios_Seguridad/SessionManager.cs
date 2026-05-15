using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios_Seguridad
{
    public class SessionManager
    {
        private static object _lock = new object(); 
        private static SessionManager _session;

        public UserBE Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        private SessionManager() { }

        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");
                return _session;
            }
        }


        public static void Login(UserBE usuario)
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

        public static void Logout(UserBE usuario)
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
