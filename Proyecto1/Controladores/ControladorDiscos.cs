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
        //static private int getMaxIDDiscos()
        //{
        //    int maxIDDiscos = -1;
        //    foreach (Artista unArtista in _listaArtistas)
        //    {
        //        if (!unArtista.getDiscos().Any())
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            if (unArtista.getDiscos().Max(d => d.getID()) > maxIDDiscos)
        //            {
        //                maxIDDiscos = unArtista.getDiscos().Max(d => d.getID());
        //            }
        //        }
        //    }
        //    return maxIDDiscos;
        //}

        public static void GuardarDisco(Artista unArtista, string nombre, int anioPublicacion, int cantidadCanciones, int duracionTotal, string tipoDisco)
        {
            Disco discoNuevo = new Disco(nombre, anioPublicacion, cantidadCanciones, duracionTotal, tipoDisco);
            //int idDisco = getMaxIDDiscos() + 1;
            //discoNuevo.setID(idDisco);
            unArtista.agregarDisco(discoNuevo);
            PersistenciaDiscos.GuardarDisco(discoNuevo, unArtista.getID());
        }

    }
}
