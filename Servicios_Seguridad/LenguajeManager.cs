using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Seguridad
{
    public class LenguajeManager
    {
        private static LenguajeManager instance;
        private List<IObserver> observers = new List<IObserver>();

        public static LenguajeManager GetInstance()
        {
            if (instance == null) instance = new LenguajeManager();
            return instance;
        }

        public void AgregarObserver(IObserver iObserver)
        {
            if (!observers.Contains(iObserver))
            {
                observers.Add(iObserver);
            }
        }

        public void RemoverObserver(IObserver iObserver)
        {
            if (observers.Contains(iObserver))
            {
                observers.Remove(iObserver);
            }
        }

        public void CambiarIdioma(int IDIdioma, DataTable dtTraducciones)
        {
            if (SessionManager.GetInstance != null && SessionManager.GetInstance.Usuario != null)
            {
                // 2. Le asignamos el nuevo ID de idioma directo al usuario logueado
                // (Cambiá "IdIdioma" por el nombre exacto que tenga la propiedad en tu UserService)
                SessionManager.GetInstance.Usuario.IdIdioma = IDIdioma;
            }

            // 3. Disparás el loop de notificación a los formularios
            NotificarTodos(dtTraducciones);
        }

        public void Notificar() { }

        private void NotificarTodos(DataTable traducciones)
        {
            foreach (var obs in observers)
            {
                obs.ActualizarIdioma(traducciones);
            }
        }
    }
}