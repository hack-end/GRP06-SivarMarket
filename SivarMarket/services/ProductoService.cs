using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SivarMarket.BD;
using SivarMarket.Models;

namespace SivarMarket.Services
{
    public class ProductoService
    {
        private readonly cn _conexion;
        private readonly ProductoService _productoService;
        private DataGridView dtgAgregProd;
    
        public ProductoService()
        {
            _conexion = new cn();
           // _productoService = new ProductoService(); // Inicialización de _productoService
        }

        public ProductoService(DataGridView dataGridView)
        {
            _conexion = new cn();
            _productoService = new ProductoService(); // Inicialización de _productoService
            dtgAgregProd = dataGridView; // Asignación del DataGridView
        }

        public DataTable ObtenerTodosProductos()
        {
            using (var con = _conexion.Conexion())
            {
                string query = @"SELECT 
                               ProductoID, Codigo, Nombre, 
                               Descripcion, Precio, Stock, 
                               CategoriaID, FechaRegistro 
                               FROM MKTSV_Producto";

                var adapter = new SqlDataAdapter(query, con);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerProductosConCategorias()
        {
            using (var con = _conexion.Conexion())
            {
                string query = @"SELECT 
                               p.ProductoID, p.Codigo, p.Nombre AS Producto, 
                               c.Nombre AS Categoria, p.Precio, p.Stock,
                               p.Descripcion, p.FechaRegistro, p.CategoriaID
                               FROM MKTSV_Producto p
                               INNER JOIN MKTSV_Categoria c 
                               ON p.CategoriaID = c.CategoriaID";

                var adapter = new SqlDataAdapter(query, con);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public Producto ObtenerProductoPorId(int id)
        {
            using (var con = _conexion.Conexion())
            {
                string query = @"SELECT ProductoID, Codigo, Nombre, Descripcion, Precio, Stock, CategoriaID, FechaRegistro 
                                 FROM MKTSV_Producto WHERE ProductoID = @id";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Producto
                            {
                                ProductoID = reader.GetInt32(reader.GetOrdinal("ProductoID")),
                                Codigo = reader.GetString(reader.GetOrdinal("Codigo")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                                Precio = reader.GetDecimal(reader.GetOrdinal("Precio")),
                                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                CategoriaID = reader.GetInt32(reader.GetOrdinal("CategoriaID")),
                                FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public DataTable ObtenerCategorias()
        {
            using (var con = _conexion.Conexion())
            {
                string query = "SELECT CategoriaID, Nombre, Descripcion FROM MKTSV_Categoria";
                var adapter = new SqlDataAdapter(query, con);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool EliminarCategoria(int categoriaId)
        {
            try
            {
                using (SqlConnection conn = new cn().Conexion())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar categoría: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

       

        public bool AgregarProducto(string codigo, string nombre, string descripcion, decimal precio, int stock, int categoriaId)
        {
            using (SqlConnection conn = new cn().Conexion())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_InsertarProducto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool EliminarProducto(int productoId)
        {
            try
            {
                using (SqlConnection conn = _conexion.Conexion())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", conn); // Usa tu SP real
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarProducto(Producto producto)
        {
            try
            {
                using (SqlConnection conn = _conexion.Conexion())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ActualizarProducto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                    cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
                return false;
            }
        }

        private void CargarTablaProductos()
        {
            try
            {
                DataTable productos = _productoService.ObtenerProductosConCategorias();
                dtgAgregProd.DataSource = productos;

                // Verifica la existencia de cada columna antes de renombrar
                if (dtgAgregProd.Columns.Contains("ProductoID"))
                    dtgAgregProd.Columns["ProductoID"].HeaderText = "ID";
                if (dtgAgregProd.Columns.Contains("Codigo"))
                    dtgAgregProd.Columns["Codigo"].HeaderText = "Código";
                if (dtgAgregProd.Columns.Contains("Nombre"))
                    dtgAgregProd.Columns["Nombre"].HeaderText = "Nombre";
                if (dtgAgregProd.Columns.Contains("Descripcion"))
                    dtgAgregProd.Columns["Descripcion"].HeaderText = "Descripción";
                if (dtgAgregProd.Columns.Contains("Precio"))
                    dtgAgregProd.Columns["Precio"].HeaderText = "Precio";
                if (dtgAgregProd.Columns.Contains("Stock"))
                    dtgAgregProd.Columns["Stock"].HeaderText = "Stock";
                if (dtgAgregProd.Columns.Contains("Categoria"))
                    dtgAgregProd.Columns["Categoria"].HeaderText = "Categoría";

                dtgAgregProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}