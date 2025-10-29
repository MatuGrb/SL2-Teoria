using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelos
{
    public class Artista
    {
        // declaracion de atributos de la clase
        private int _id = 0;
        private string _nombreCompleto;
        private string _nombreArtistico;
        private int _anioInicio;
        private string _nacionalidad;
        private string _discografica;
        private int _CantidadDiscos;
        private List<Disco> _listaDiscos = new List<Disco>();

        // constructor de la clase
        public Artista(string nombreCompleto, string nombreArtistico)
        {
            // inicializacion de valores
            _nombreCompleto = nombreCompleto;
            _nombreArtistico = nombreArtistico;
        }
        public void setAnioInicio(int anioInicio)
        {
            _anioInicio = anioInicio;
        }

        public int getAnioInicio()
        {
            return _anioInicio;
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set
            {
                if (value != String.Empty)
                {
                    _nacionalidad = value;
                }
            }
        }

        public string Discografica
        {
            get { return _discografica; }
            set
            {
                if (value != String.Empty)
                {
                    _discografica = value;
                }
            }
        }

        public string NombreCompleto { get { return _nombreCompleto; } }

        public string NombreArtistico { get { return _nombreArtistico; } }

        public override string ToString()
        {
            return $"{_nombreArtistico} ({_anioInicio}) - Discos cargados: {_CantidadDiscos}";
        }

        public void agregarDisco(Disco discoNuevo)
        {
            // TODO: agregar control de duplicados
            _listaDiscos.Add(discoNuevo);
        }

        public List<Disco> getDiscos()
        {
            return _listaDiscos;
        }

        public int getID()
        {
            return _id;
        }

        public void setID(int id)
        {
            _id = id;
        }
        
        public void setCantidadDiscos (int cantDisc){
            this._CantidadDiscos = cantDisc;
        }

        public int CantidadDiscos
        {
            get { return _listaDiscos.Count; }
        }

    }
}
