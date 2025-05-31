using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivarMarket.Models
{
    internal class Usuario
    {
        private string Correo, Contrasena;

        public Usuario(string usuario, string contrasena)
        {
            Correo = usuario;
            Contrasena = contrasena;
        }

        public bool validarUsuario(SqlConnection con)
        {
            // Consulta SQL para verificar si el usuario y la contraseña existen
            string query = "SELECT UsuarioID, Rol FROM MKTSV_Usuario WHERE Correo = @Usuario AND Contrasena = @Contrasena";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Usuario", Correo);
                command.Parameters.AddWithValue("@Contrasena", Contrasena);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        SesionUsuario.UsuarioId = reader.GetInt32(reader.GetOrdinal("UsuarioID"));
                        SesionUsuario.Rol = reader.GetString(reader.GetOrdinal("Rol"));
                        return true; // Usuario encontrado
                    }
                }
            }
            return false;
        }
    }
}
