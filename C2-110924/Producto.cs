using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924
{
    internal class Producto
    {
        private string _id;
        private string _nombre;
        private int _cantidad;

        public Producto(string id,  string nombre, int cantidad)
        {
            _id = id;
            _nombre = nombre;
            _cantidad = cantidad;
        }

        public string ID
        {
            get { return _id; }
            set
            {
                if (value != String.Empty)
                {
                    _id = value;
                }
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value != String.Empty)
                {
                    _nombre = value;
                }
            }
        }
        
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value > 0)
                {
                    _cantidad = value;
                }
            }
        }
        public override string ToString()
        {
            // Personaliza la representación de la instancia como cadena
            return $"{_nombre} [{_id}] | Stock actual: {_cantidad}";
        }

    }
}
