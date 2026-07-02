using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace BLL
{
    public class IdiomaBLL
    {
        
        private readonly string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "idiomas.json")
;
        public Dictionary<int, string> ObtenerIdiomasDisponibles()
        {
            return new Dictionary<int, string>
            {
                { 1, "Español" },
                { 2, "English" }
            };
        }

        public Dictionary<string, string> ObtenerTraduccionesJson(int idIdioma)
        {
            var diccionarioTraducciones = new Dictionary<string, string>();

            try
            {
                if (!File.Exists(rutaJson)) return diccionarioTraducciones;

                
                string contenidoJson = File.ReadAllText(rutaJson);

                
                string[] partes = contenidoJson.Split('"');
                bool dentroDelIdioma = false;

                for (int i = 0; i < partes.Length; i++)
                {
                    
                    if (partes[i] == idIdioma.ToString() && i + 1 < partes.Length && partes[i + 1].Contains("{"))
                    {
                        dentroDelIdioma = true;
                        continue;
                    }

                   
                    if (dentroDelIdioma && partes[i].Contains("}"))
                    {
                        
                        if (partes[i].IndexOf('}') < partes[i].IndexOf('{') || !partes[i].Contains("{"))
                        {
                            dentroDelIdioma = false;
                            break;
                        }
                    }

                   
                    if (dentroDelIdioma && i + 2 < partes.Length && partes[i + 1].Contains(":"))
                    {
                        string clave = partes[i].Trim();
                        string valor = partes[i + 2].Trim();

                        
                        if (!string.IsNullOrEmpty(clave) && partes[i + 1].IndexOf(':') >= 0 && !diccionarioTraducciones.ContainsKey(clave))
                        {
                            diccionarioTraducciones.Add(clave, valor);
                            i += 2; 
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return diccionarioTraducciones;
        }
    }
}