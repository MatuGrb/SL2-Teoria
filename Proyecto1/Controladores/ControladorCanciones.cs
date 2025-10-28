using Proyecto1.Modelos;
using Proyecto1.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controladores {
    internal class ControladorCanciones {

        public static bool GuardarCancion (string nombre,int anioLanzamiento, int duracion, Disco discoRelacionado) {
            Cancion unaCancion = new Cancion(nombre, anioLanzamiento, duracion, discoRelacionado);
            discoRelacionado.AgregarCancion(unaCancion);
            return (PersistenciaCanciones.GuardarCancion(unaCancion, discoRelacionado.getID())); 
        }

        public static void InicializarUltimoID () {
            PersistenciaCanciones.ObtenerUltimoID();
        }

        public static List<Cancion> ObtenerCanciones (int idDisco) {
            try
            {
                List<Cancion> listCanciones = new List<Cancion>();
                listCanciones = PersistenciaCanciones.LeerCanciones(idDisco);
                // Si esto es null no existe el archivo
                if (listCanciones.Count > 0)
                {
                    return listCanciones;
                }
                else
                {
                    throw new Exception("No hay canciones cargadas");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las canciones: " + ex.Message);
            }
        }
    }
}
