using Proyecto1.Modelos;
using Proyecto1.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controladores {
    internal class ControladorCanciones {

        public static void GuardarCancion (string nombre,int anioLanzamiento, int duracion, Disco discoRelacionado) {
            Cancion unaCancion = new Cancion(nombre, anioLanzamiento, duracion, discoRelacionado);
            //PersistenciaArtistas.GuardarCancion(unaCancion); IMPLEMENTARRRRRRRRRRRRRRRRRRRRRRRR
        }

        public static List<Cancion> ObtenerCanciones () {
            List<Cancion> listado = new List<Cancion>();
            //listado = PersistenciaCanciones.LeerCanciones();
            // Si esto es null no existe el archivo
            if (listado.Count > 0) {
                return listado;
            } else {
                throw new Exception("No hay canciones cargadas");
            }
        }

        public static void InicializarUltimoID () {
            //PersistenciaCanciones.ObtenerUltimoID();
        }
    }
}
