using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Seguridad
{
    public interface IObserver
    {
        void ActualizarIdioma(object traducciones);
    }
}
