using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBusiness.GetProductosVendidos().ToArray();
        }

        [HttpDelete(Name = "DeleteProductoVendido")]
        public void Delete([FromBody] int Id)
        {
            ProductoVendidoBusiness.EliminarProductoVendido(Id);
        }

        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBusiness.ModificarProductoVendido(productoVendido);
        }

        [HttpPost(Name = "CrearProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBusiness.CrearProductoVendido(productoVendido);
        }
    }
}
