using System;
using System.Data;
using System.Data.SqlClient;

namespace SivarMarket.Models
{
    public class Producto
    {
        // Propiedades públicas (acceso moderno)
        public int ProductoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaID { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string NombreCompleto => $"{Codigo} - {Nombre}";

        // Constructor por defecto
        public Producto() { }

        // Método de consulta mejorado
        public DataTable ConsultarProductos(SqlConnection con)
        {
            string query = @"SELECT 
                           p.ProductoID,
                           p.Codigo, 
                           p.Nombre AS Producto, 
                           c.Nombre AS Categoria, 
                           p.Precio, 
                           p.Stock,
                           p.Descripcion,
                           p.FechaRegistro,
                           p.CategoriaID
                           FROM MKTSV_Producto p 
                           INNER JOIN MKTSV_Categoria c 
                           ON p.CategoriaID = c.CategoriaID";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Método adicional para mapear desde DataRow
        public static Producto FromDataRow(DataRow row)
        {
            return new Producto
            {
                ProductoID = Convert.ToInt32(row["ProductoID"]),
                Codigo = row["Codigo"].ToString(),
                Nombre = row["Producto"].ToString(),
                Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : null,
                Precio = Convert.ToDecimal(row["Precio"]),
                Stock = Convert.ToInt32(row["Stock"]),
                CategoriaID = Convert.ToInt32(row["CategoriaID"]),
                FechaRegistro = Convert.ToDateTime(row["FechaRegistro"])
            };
        }
    }
}