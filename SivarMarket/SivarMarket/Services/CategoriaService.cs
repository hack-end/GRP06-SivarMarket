using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SivarMarket.BD;
using SivarMarket.Models;

namespace SivarMarket.Services
{
    public class CategoriaService
    {
        private readonly cn _conexion = new cn();

        public bool AgregarCategoria(string nombre, string descripcion)
        {
            using (SqlConnection con = _conexion.Conexion())
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                con.Open();
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
        }

        public List<Categoria> BuscarCategorias(string texto)
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection con = _conexion.Conexion())
            {
                SqlCommand cmd = new SqlCommand("SP_BuscarCategorias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Busqueda", texto);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Categoria
                    {
                        CategoriaID = Convert.ToInt32(reader["CategoriaID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    });
                }
            }

            return lista;
        }

        public bool ActualizarCategoria(int categoriaId, string nombre, string descripcion)
        {
            using (SqlConnection con = _conexion.Conexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ActualizarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                con.Open();
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
        }



    }
}
