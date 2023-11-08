using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public class LoginBusiness
    {
        public void Ingresar (string nombreUsuario, string contraseña)
        {
            LoginData.Ingresar(nombreUsuario, contraseña);
        }
    }
}
