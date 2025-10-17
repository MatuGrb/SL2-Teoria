using Proyecto1.Modelos;
using Proyecto1.Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto1.Persistencia
{
    internal static class PersistenciaArtistas
    {
        private static int _ultimoID;

        private static string GetPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void ObtenerUltimoID()
        {
            string fullPath = Path.Combine(GetPath(), "datos_artistas.txt");
            string ultimaLinea = null;
            //string ultimaLinea = File.ReadLines(fullPath).LastOrDefault();
            try
            {
                // Intenta leer la última línea del archivo.
                // File.ReadLines es eficiente ya que no carga todo el archivo en memoria.
                ultimaLinea = File.ReadLines(fullPath).LastOrDefault();
            }
            catch (FileNotFoundException ex)
            {
                // Maneja el caso en que la ruta del archivo es inválida o el archivo no existe.
                Console.WriteLine($"Error: El archivo no fue encontrado en '{fullPath}'. Detalles: {ex.Message}");
                // Aquí puedes registrar el error, notificar al usuario, o establecer un valor por defecto.
            }
            catch (System.Security.SecurityException ex)
            {
                // Maneja el caso en que la aplicación no tiene los permisos necesarios.
                Console.WriteLine($"Error de Permisos: No se pudo acceder al archivo. Detalles: {ex.Message}");
            }
            catch (IOException ex)
            {
                // Captura otros errores de I/O, como problemas con el disco o el nombre de ruta demasiado largo.
                Console.WriteLine($"Error de I/O: Ocurrió un error al leer el archivo. Detalles: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Captura cualquier otra excepción no esperada.
                Console.WriteLine($"Error Inesperado: {ex.Message}");
            }
            if (ultimaLinea == null)
            {
                _ultimoID = 0;
            }
            else
            {
                var datos = ultimaLinea.Split('|');
                _ultimoID = int.Parse(datos[0]);
            }
        }

        public static void GuardarArtista(Artista unArtista)
        {
            string fullPath = Path.Combine(GetPath(), "datos_artistas.txt");
            unArtista.setID(_ultimoID + 1);
            if (!File.Exists(fullPath))
            {
                // El archivo no existe
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    string datos = $"{unArtista.getID()}|{unArtista.NombreCompleto}|{unArtista.NombreArtistico}|{unArtista.getAnioInicio()}|{unArtista.Nacionalidad}|{unArtista.Discografica}";
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
                    string datos = $"{unArtista.getID()}|{unArtista.NombreCompleto}|{unArtista.NombreArtistico}|{unArtista.getAnioInicio()}|{unArtista.Nacionalidad}|{unArtista.Discografica}";
                    outputFile.WriteLine(datos);
                }
                //MessageBox.Show("Archivo actualizado correctamente.");
            }
        }

        public static List<Artista> LeerArtistas()
        {
            string fullPath = Path.Combine(GetPath(), "datos_artistas.txt");
            List<Artista> resultados = new List<Artista>();
            if (File.Exists(fullPath))
            {
                string[] lineas = File.ReadAllLines(fullPath);
                foreach (string line in lineas)
                {
                    var datos = line.Split('|');
                    Artista unArtista = new Artista(datos[1], datos[2]);
                    unArtista.setID(int.Parse(datos[0]));
                    unArtista.setAnioInicio(int.Parse(datos[3]));
                    unArtista.Nacionalidad = datos[4];
                    unArtista.Discografica = datos[5];
                    resultados.Add(unArtista);
                }
                // traer todos los discos
                //PersistenciaDiscos.LeerDiscosArtistas(resultados);
                return resultados;
            }
            else
            {
                // El archivo no existe
                return resultados;
            }
        }

        
    }
}
