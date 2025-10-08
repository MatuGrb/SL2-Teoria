using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Proyecto1.PersistenciaArtistas;

namespace Proyecto1
{
    internal static class ControladorArtistas
    {
        public static void GuardarArtista(string nombreCompleto, string nombreArtistico, int anioInicio, string nacionalidad, string discografica)
        {
            Artista unArtista = new Artista(nombreCompleto, nombreArtistico);
            unArtista.setAnioInicio(anioInicio);
            unArtista.Nacionalidad = nacionalidad;
            unArtista.Discografica = discografica;
            PersistenciaArtistas.GuardarArtista(unArtista);
        }

        public static List<Artista> ObternerArtistas()
        {
            List<Artista> listado = new List<Artista>();
            listado = PersistenciaArtistas.LeerArtistas();
            // Si esto es null no existe el archivo
            if (listado.Count > 0 )
            {
                return listado;
            }
            else
            {
                throw new Exception("No hay artistas cargados");
            }
        }

        public static void GuardarDisco(Artista unArtista, string nombre, int anioPublicacion, int cantidadCanciones, int duracionTotal, string tipoDisco)
        {
            Disco discoNuevo = new Disco(nombre, anioPublicacion, cantidadCanciones, duracionTotal, tipoDisco);
            unArtista.agregarDisco(discoNuevo);
            PersistenciaArtistas.GuardarDisco(discoNuevo, unArtista.getID());
        }

    }
}
