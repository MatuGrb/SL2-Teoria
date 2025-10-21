using Proyecto1.Modelos;
using Proyecto1.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Persistencia
{
    internal class PersistenciaDiscos
    {
        private static int _ultimoID;
        private static string GetPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void ObtenerUltimoID () {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            string ultimaLinea = string.Empty; // Inicialización para evitar CS0165
            try {
                string? ultimaLineaNullable = File.ReadLines(fullPath).LastOrDefault();
                ultimaLinea = ultimaLineaNullable ?? string.Empty;
            } catch (FileNotFoundException ex) {
                Console.WriteLine($"Error: El archivo no fue encontrado en '{fullPath}'. Detalles: {ex.Message}");
            } catch (System.Security.SecurityException ex) {
                Console.WriteLine($"Error de Permisos: No se pudo acceder al archivo. Detalles: {ex.Message}");
            } catch (IOException ex) {
                Console.WriteLine($"Error de I/O: Ocurrió un error al leer el archivo. Detalles: {ex.Message}");
            } catch (Exception ex) {
                Console.WriteLine($"Error Inesperado: {ex.Message}");
            }
            if (string.IsNullOrEmpty(ultimaLinea)) {
                _ultimoID = 0;
            } else {
                var datos = ultimaLinea.Split('|');
                _ultimoID = int.Parse(datos[0]);
            }
        }

        public static bool GuardarDisco(Disco unDisco, int idArtista)
        {
            try {
                string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
                unDisco.setID(_ultimoID + 1);
                if (!File.Exists(fullPath)) {
                    // El archivo no existe
                    using (StreamWriter outputFile = new StreamWriter(fullPath)) {
                        string datos = $"{unDisco.getID()}|{unDisco.Nombre}|{unDisco.AnioLanzamiento}|{unDisco.CantidadCanciones}|{unDisco.DuracionTotal}|{unDisco.TipoDisco}|{idArtista}";
                        outputFile.WriteLine(datos);
                    }
                    return true;
                } else {
                    // El archivo ya existe, agregamos el mismo contenido
                    using (StreamWriter outputFile = new StreamWriter(fullPath, true)) {
                        // Escribir el contenido del archivo línea a línea
                        string datos = $"{unDisco.getID()}|{unDisco.Nombre}|{unDisco.AnioLanzamiento}|{unDisco.CantidadCanciones}|{unDisco.DuracionTotal}|{unDisco.TipoDisco}|{idArtista}";
                        outputFile.WriteLine(datos);
                    }
                    return false;
                }
            } catch (Exception e){
                throw new Exception("Error al guardar el disco:",e);
            }
        }

        public static List<Disco> LeerDiscosDeArtista (int idArtistaBuscado) {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            List<Disco> resultados = new List<Disco>();

            if (File.Exists(fullPath)) {
                string[] lineas = File.ReadAllLines(fullPath);

                foreach (string line in lineas) {
                    var datos = line.Split('|');

                    // Extraemos el ID del artista de la línea actual del archivo
                    int idArtistaDelArchivo = int.Parse(datos[6]);

                    // Comparamos si el ID del artista del archivo es igual al que buscamos
                    if (idArtistaDelArchivo == idArtistaBuscado) {
                        // Si coinciden, creamos el objeto Disco y lo agregamos a la lista
                        Disco unDisco = new Disco(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5]);
                        unDisco.setID(int.Parse(datos[0]));
                        resultados.Add(unDisco);
                    }
                }
            }
            // Devolvemos la lista de resultados (estará vacía si no se encontró el archivo o no había discos)
            return resultados;
        }
    }
}
