using Proyecto1.Modelos;
using Proyecto1.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controladores
{
    internal class ControladorDiscos
    {
        public static bool GuardarDisco(Artista unArtista, string nombre, int anioPublicacion, int cantidadCanciones, int duracionTotal, string tipoDisco)
        {
            Disco discoNuevo = new Disco(nombre, anioPublicacion, cantidadCanciones, duracionTotal, tipoDisco);
            unArtista.agregarDisco(discoNuevo);
            return (PersistenciaDiscos.GuardarDisco(discoNuevo, unArtista.getID()));
        }
        public static void InicializarUltimoID () {
            PersistenciaDiscos.ObtenerUltimoID();
        }
        public static List<Disco> ObtenerDiscos (int idArtista) {
            List<Disco> listado = new List<Disco>();
            listado = PersistenciaDiscos.LeerDiscosDeArtista(idArtista);
            // Si esto es null no existe el archivo
            if (listado.Count > 0) {
                return listado;
            } else {
                throw new Exception("No hay discos cargados");
            }
        }
    }
}
