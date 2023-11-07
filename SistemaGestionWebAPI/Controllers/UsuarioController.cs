using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBusiness.GetUsuarios().ToArray();
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public void Delete([FromBody] int Id)
        {
            UsuarioBusiness.EliminarUsuario(Id);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBusiness.ModificarUsuario(usuario);
        }

        [HttpPost(Name = "CrearUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBusiness.CrearUsuario(usuario);
        }
    }
}
