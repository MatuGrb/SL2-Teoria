using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924
{
    internal static class ProductosService
    {
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarProducto(Producto unProducto)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "datos.txt");
            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    string datos = $"{unProducto.Nombre};{unProducto.Cantidad}";
                    archivoSalida.WriteLine(datos);
                }
            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    string datos = $"{unProducto.Nombre};{unProducto.Cantidad}";
                    archivoSalida.WriteLine(datos);
                }
            }
        }

    }
}
