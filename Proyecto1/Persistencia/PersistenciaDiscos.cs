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

        private static string GetPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarDisco(Disco unDisco, int idArtista)
        {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            // UltimoIdDisco();
            // unDisco.setID(GenerarIdDisco());
            if (!File.Exists(fullPath))
            {
                // archivo nuevo
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    string datos = $"{unDisco.getID()}|{unDisco.Nombre}|{unDisco.AnioLanzamiento}|{unDisco.CantidadCanciones}|{unDisco.DuracionTotal}|{unDisco.TipoDisco}|{idArtista}";
                    outputFile.WriteLine(datos);
                }
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath, true))
                {
                    string datos = $"{unDisco.getID()}|{unDisco.Nombre}|{unDisco.AnioLanzamiento}|{unDisco.CantidadCanciones}|{unDisco.DuracionTotal}|{unDisco.TipoDisco}|{idArtista}";
                    outputFile.WriteLine(datos);
                }
            }
        }

        public static List<Artista> LeerDiscosArtistas(List<Artista> listaArtistas)
        {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            List<Disco> resultados = new List<Disco>();
            if (File.Exists(fullPath))
            {
                string[] lineas = File.ReadAllLines(fullPath);
                foreach (string line in lineas)
                {
                    var datos = line.Split('|');
                    //string datos = $"{unDisco.getID()}|{unDisco.Nombre}|{unDisco.AnioLanzamiento}|{unDisco.CantidadCanciones}|{unDisco.DuracionTotal}|{unDisco.TipoDisco}|{idArtista}";
                    Disco unDisco = new Disco(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5]);
                    unDisco.setID(int.Parse(datos[0]));
                    int idArtista = int.Parse(datos[6]);
                    resultados.Add(unDisco);
                    Artista artistaAsociado = listaArtistas.FirstOrDefault(a => a.getID() == idArtista);
                    artistaAsociado?.agregarDisco(unDisco);
                }
                return listaArtistas;
            }
            else
            {
                return listaArtistas;
            }
        }

        public static List<Disco> LeerDiscos()
        {
            string fullPath = Path.Combine(GetPath(), "datos_discos.txt");
            List<Disco> resultados = new List<Disco>();
            if (File.Exists(fullPath))
            {
                List<Artista> listaArtistas = PersistenciaArtistas.LeerArtistas();
                string[] lineas = File.ReadAllLines(fullPath);
                foreach (string line in lineas)
                {
                    var datos = line.Split('|');
                    // string datos = $"{unDisco.getID()}|{unDisco.Nombre}|{unDisco.AnioLanzamiento}|{unDisco.CantidadCanciones}|{unDisco.DuracionTotal}|{unDisco.TipoDisco}|{idArtista}";
                    Disco unDisco = new Disco(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5]);
                    unDisco.setID(int.Parse(datos[0]));
                    int idArtista = int.Parse(datos[6]);
                    resultados.Add(unDisco);
                    Artista artistaAsociado = listaArtistas.FirstOrDefault(a => a.getID() == idArtista);
                    artistaAsociado?.agregarDisco(unDisco);
                }
                return resultados;
            }
            else
            {
                return resultados;
            }
        }
    }
}
