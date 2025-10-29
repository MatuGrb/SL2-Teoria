using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Persistencia
{
    internal class PersistenciaCanciones
    {
        private static int _ultimoID;
        private static string GetPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void ObtenerUltimoID()
        {
            string fullPath = Path.Combine(GetPath(), "datos_canciones.txt");
            string ultimaLinea = string.Empty;

            try{
                // Intenta leer la última línea del archivo.
                // File.ReadLines es eficiente ya que no carga todo el archivo en memoria.
                string? ultimaLineaNullable = File.ReadLines(fullPath).LastOrDefault();
                ultimaLinea = ultimaLineaNullable ?? string.Empty;
            }
            catch (FileNotFoundException ex){
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

            if (string.IsNullOrEmpty(ultimaLinea))
            {
                _ultimoID = 0;
            }
            else
            {
                var datos = ultimaLinea.Split('|');
                _ultimoID = int.Parse(datos[0]);
            }
        }

        public static bool GuardarCancion(Cancion unaCancion, int idDisco)
        {
            try
            {
                string fullPath = Path.Combine(GetPath(), "datos_canciones.txt");
                unaCancion.setID(_ultimoID + 1);

                if (!File.Exists(fullPath))
                {
                    // El archivo no existe
                    using (StreamWriter outputFile = new StreamWriter(fullPath))
                    {
                        string datos = $"{unaCancion.getID()}|{unaCancion.Nombre}|{unaCancion.AnioLanzamiento}|{unaCancion.DuracionSeg}|{idDisco}";
                        outputFile.WriteLine(datos);
                    }
                    return true;
                    //MessageBox.Show("Archivo creado y datos guardados correctamente.");
                }
                else
                {
                    // El archivo ya existe, agregamos el mismo contenido
                    using (StreamWriter outputFile = new StreamWriter(fullPath, true))
                    {
                        // Escribir el contenido del archivo línea a línea
                        string datos = $"{unaCancion.getID()}|{unaCancion.Nombre}|{unaCancion.AnioLanzamiento}|{unaCancion.DuracionSeg}|{idDisco}";
                        outputFile.WriteLine(datos);
                    }
                    return false;
                    //MessageBox.Show("Archivo actualizado correctamente.");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar la canción:", e);
            }
        }

        public static List<Cancion> LeerCanciones(int idDisco)
        {
            try
            {

                string fullPath = Path.Combine(GetPath(), "datos_canciones.txt");
                List<Cancion> cancionesDisco = new List<Cancion>();

                if (File.Exists(fullPath))
                {
                    string[] lineas = File.ReadAllLines(fullPath);

                    foreach (string line in lineas)
                    {
                        var datos = line.Split('|');

                        int idDiscoArchivo = int.Parse(datos[4]);

                        if (idDiscoArchivo == idDisco)
                        {
                            Disco discoRelacionado = PersistenciaDiscos.BuscarDiscoPorID(idDisco); // Aquí podrías implementar la lógica para obtener el objeto Disco relacionado si es necesario.
                            // Si coinciden, creamos el objeto Cancion y lo agregamos a la lista
                            Cancion unaCancion = new Cancion(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), discoRelacionado);
                            unaCancion.setID(int.Parse(datos[0]));
                            cancionesDisco.Add(unaCancion);
                        }
                    }
                }

                return cancionesDisco;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer las canciones:", e);
            }
        }

        public static int CantidadCancionesEnDisco(int idDisco)
        {
            List<Cancion> canciones = LeerCanciones(idDisco);
            return canciones.Count;
        }
    }
}
