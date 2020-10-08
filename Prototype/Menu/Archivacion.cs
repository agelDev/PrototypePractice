using System;
using System.Collections.Generic;
using Prototype.Persona;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace Prototype.Menu
{
    public partial class Menu
    {
        public static void Archivar(List<Persona.Persona> lista, string ruta)
        {
            if (!File.Exists(ruta))
                File.Create(ruta);

            Archivador<Persona.Persona> archivador = new Archivador<Persona.Persona>(lista, ruta);
            archivador.Guardar();
        }

        class Archivador<T>
        {
            List<T> Valores { get; set; }
            string Ruta { get; set; }
            
            public Archivador(List<T> valores, string ruta) {
                Valores = valores;
                Ruta = ruta;
            }

            public void Write(FileStream fs)
            {
                string texto = JsonConvert.SerializeObject(Valores);
                using (fs)
                {
                    AddText(fs, texto);
                }
            }

            private static void AddText(FileStream fs, string value)
            {
                byte[] info = new UTF8Encoding(true).GetBytes(value);
                fs.Write(info, 0, info.Length);
            }

            public void Guardar()
            {
                if (File.Exists(Ruta))
                    File.Delete(Ruta);

                Write(File.Create(Ruta));
            }

            public void Cargar()
            {
                string archivo = File.ReadAllText(Ruta);
                Valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
        }
    }
}
