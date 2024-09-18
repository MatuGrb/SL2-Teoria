using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924
{
    internal class Producto
    {
        private string _nombre;
        private int _cantidad;

        public Producto(string nombre, int cantidad)
        {
            _nombre = nombre;
            _cantidad = cantidad;
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
    }
}
