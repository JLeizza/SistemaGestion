using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class LoginData
    {
        public static bool Ingresar(string nombreUsuario, string contraseña)
        {
            string connectionString = @"Server=Julen\SQLEXPRESS01;Database=SistemaGestion;Trusted_Connection=True";
            string query = @"SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            string contraseñaDB = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                  

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.NVarChar) { Value = nombreUsuario });

                        contraseñaDB = (string)comando.ExecuteScalar() as string;
                    }

                    conexion.Close();
                }

                if (contraseñaDB != null && contraseñaDB.Equals(contraseña))
                {
                
                    return true;
                }
            }
            catch (Exception ex)
            {
      
                Console.WriteLine("Error: " + ex.Message);
            }

            return false;

        }
    }

}

