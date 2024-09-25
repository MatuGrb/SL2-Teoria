using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924
{
    internal static class ProductosController
    {
        // Este es nuestro controlador del negocio
        public static void GuardarProducto(Producto unProducto) 
        {
            // Acá debería haber algún tipo de lógica implementada

            // Mandamos los datos al almacenamiento
            ProductosService.GuardarProducto(unProducto);
        }
        
        public static List<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>();
            productos = ProductosService.LeerProductos();
            if (productos != null)
            {
                // Existen productos y está caargada la colección
                return productos;
            }
            else
            {
                throw new Exception("No hay productos para mostrar");
            }
        }

    }
}
