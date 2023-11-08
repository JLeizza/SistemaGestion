using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;


//[HttpPost(Name = "Ingresar")]
//  public void Post([FromBody] Registro registro)
//  {
//      LoginBusiness.Ingresar(registro);

//  }

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginBusiness _loginBusiness;

        public LoginController(LoginBusiness loginBussiness)
        {
            _loginBusiness = loginBussiness;
        }

       

        [HttpPost]
        public IActionResult Autenticar([FromBody] Registro request, LoginBusiness _loginBusiness)
        {
            if (request == null)
            {
                return BadRequest("Los datos de inicio de sesión son nulos.");
            }

            try
            {
 
                var usuarioAutenticado = _loginBusiness.Ingresar(request.NombreUsuario, request.Contrasena);

                if (usuarioAutenticado == null)
                {
                    return BadRequest("Credenciales incorrectas. Por favor, verifique su nombre de usuario y contraseña.");
                }

                return Ok("Autenticación exitosa");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al autenticar: {ex.Message}");
            }
        }


    }
}
