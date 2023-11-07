using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public static class ProductoBusiness
    {
        public static List<Producto> GetProductos() 
        {
            return ProductoData.ListarProductos();
        }

        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void EliminarProducto(int Id)
        {
            ProductoData.EliminarProducto(Id);
        }

        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }
    }
}
