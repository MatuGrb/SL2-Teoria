using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto1
{
    internal static class PersistenciaArtistas
    {
        private static string GetPath()
        {
            return AppContext.BaseDirectory;
        }
        public static void GuardarArtista(Artista unArtista)
        {
            string fullPath = Path.Combine(GetPath(), "datos_artistas.txt");
            if (!File.Exists(fullPath))
            {
                // El archivo no existe
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    string datos = $"{unArtista.NombreCompleto}|{unArtista.NombreArtistico}|{unArtista.getAnioInicio()}|{unArtista.Nacionalidad}|{unArtista.Discografica}";
                    outputFile.WriteLine(datos);
                }
                //MessageBox.Show("Archivo creado y datos guardados correctamente.");
            }
            else
            {
                // El archivo ya existe, agregamos el mismo contenido
                using (StreamWriter outputFile = new StreamWriter(fullPath, true))
                {
                    // Escribir el contenido del archivo línea a línea
                    string datos = $"{unArtista.NombreCompleto}|{unArtista.NombreArtistico}|{unArtista.getAnioInicio()}|{unArtista.Nacionalidad}|{unArtista.Discografica}";
                    outputFile.WriteLine(datos);
                }
                //MessageBox.Show("Archivo actualizado correctamente.");
            }
        }
    }
}
