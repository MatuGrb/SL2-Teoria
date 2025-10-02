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
    }
}
