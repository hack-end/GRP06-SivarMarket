using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivarMarket.Models
{
    public class Producto
    {

        // Propiedades públicas
        public int ProductoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaID { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string NombreCompleto => $"{Codigo} - {Nombre}";

        //Constructores
        public Producto() { }

        //Consultas
        public DataTable consultarProductos(SqlConnection con)
        {
            using (SqlCommand comand = new SqlCommand("SP_ConsultarProductos", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter datos = new SqlDataAdapter(comand);
                DataTable dataTable = new DataTable();
                datos.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable consultarProductoFiltrado(SqlConnection con, string dato)
        {
            using (SqlCommand comand = new SqlCommand("SP_ConsultarProductoFiltrado", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@Busqueda", "%" + dato + "%");
                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Buscar productoID por su codigo
        public int obtenerProductoID(SqlConnection con, string codigo)
        {
            using (SqlCommand comand = new SqlCommand("SP_ObtenerProductoID", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@Codigo", codigo);

                object result = comand.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

    }
}
