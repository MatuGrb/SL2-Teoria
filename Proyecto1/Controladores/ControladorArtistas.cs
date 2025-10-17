using Proyecto1.Modelos;
using Proyecto1.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using Proyecto1.PersistenciaArtistas;

namespace Proyecto1.Controladores
{
    internal static class ControladorArtistas
    {
        //static List<Artista> _listaArtistas = new List<Artista>();

        //public static List<Artista> getListaArtistas()
        //{
        //    return _listaArtistas;
        //}

        public static void GuardarArtista(string nombreCompleto, string nombreArtistico, int anioInicio, string nacionalidad, string discografica)
        {
            Artista unArtista = new(nombreCompleto, nombreArtistico);
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

        public static void InicializarUltimoID()
        {
            PersistenciaArtistas.ObtenerUltimoID();
        }

    }
}
