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
        private static LenguajeManager _instance;
        private List<IObserver> _observers = new List<IObserver>();

        //propidad xa guardar las traducciones actuales en la memoria
        public Dictionary<string, string> TraduccionesActuales { get; private set; }
        public int IdIdiomaActual { get; private set; }

        private LenguajeManager() { }

        public static LenguajeManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LenguajeManager();
            }
            return _instance;
        }

        public void AgregarObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoverObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        
        //recibe el id idioma y el diccionario del json, lo guarda y notifica a las patannllas
        public void CambiarIdioma(int idIdioma, Dictionary<string, string> traducciones)
        {
            IdIdiomaActual = idIdioma;
            TraduccionesActuales = traducciones;

            NotificarObservers();
        }

        private void NotificarObservers()
        {
            foreach (var observer in _observers)
            {
                //le paso el diccionario actual a cada formulario abierto para que se actualice solo
                observer.ActualizarIdioma(TraduccionesActuales);
            }
        }
    }
}