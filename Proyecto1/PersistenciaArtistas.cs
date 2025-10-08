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
        private static int _ultimoIdArtista = 0;
        private static int _ultimoIdDisco = 0;

        private static void UltimoIdArtista()
        {
            var artistas = LeerArtistas();
            if (artistas.Any())
            {
                // Encuentra el ID más grande entre los artistas cargados
                _ultimoIdArtista = artistas.Max(a => a.getID());
            }
            else
            {
                _ultimoIdArtista = 0;
            }
        }

        private static int GenerarIdArtista()
        {
            // Incrementa el último ID y lo devuelve para el nuevo artista
            _ultimoIdArtista++;
            return _ultimoIdArtista;
        }

        private static string GetPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarArtista(Artista unArtista)
        {
            string fullPath = Path.Combine(GetPath(), "datos_artistas.txt");
            UltimoIdArtista();
            unArtista.setID(GenerarIdArtista());
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
                return resultados;
            }
            else
            {
                // El archivo no existe
                return resultados;
            }
        }

        private static void UltimoIdDisco()
        {
            var discos = LeerDiscos();
            if (discos.Any())
            {
                // Encuentra el ID más grande entre los discos cargados
                _ultimoIdDisco = discos.Max(d => d.getID());
            }
            else
            {
                _ultimoIdDisco = 0;
            }
        }

        private static int GenerarIdDisco()
        {
            // Incrementa el último ID y lo devuelve para el disco nuevo
            _ultimoIdDisco++;
            return _ultimoIdDisco;
        }

        public static void GuardarDisco(Disco undisco)
        {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            UltimoIdDisco();
            undisco.setID(GenerarIdDisco());
            if (!File.Exists(fullPath))
            {

            }
            else
            {

            }
        }

        public static List<Disco> LeerDiscos()
        {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            List<Disco> resultados = new List<Disco>();
            if (File.Exists(fullPath))
            {

                return resultados;
            }
            else
            {
                return resultados;
            }
        }
    }
}
