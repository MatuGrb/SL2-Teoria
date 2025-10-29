using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelos {
    public class Cancion {
        // definición de atributos
        private int _id = 0;
        private string _nombreCancion;
        private int _anioLanzamientoCancion;
        private int _duracionCancion;

        private Disco _discoRelacionado; //disco al que está relacionado

        public Cancion (string nombre, int anioLanzamiento, int duracion, Disco discoRelacionado) {
            _nombreCancion = nombre; 
            _anioLanzamientoCancion = anioLanzamiento;
            _duracionCancion = duracion;
            _discoRelacionado = discoRelacionado;
        }

        public string Nombre { get { return _nombreCancion; } }
        public int AnioLanzamiento { get { return _anioLanzamientoCancion; } }

        public int getID () {
            return _id;
        }

        public void setID (int id) {
            _id = id;
        }

        public override string ToString () {
            string nombreDisco = _discoRelacionado.Nombre;
            return $"Nombre: {_nombreCancion}, Duración: {_duracionCancion} segundos, disco asociado: {nombreDisco}";
        }

        public int DuracionSeg { get { return _duracionCancion; } }
        public Disco DiscoRelacionado { get { return _discoRelacionado; } }
    }
}
