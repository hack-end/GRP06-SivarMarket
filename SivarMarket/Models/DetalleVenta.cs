using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SivarMarket.Models
{
    internal class DetalleVenta
    {
        private int DetalleVentaID, VentaID, ProductoID, Cantidad;
        private decimal PrecioUnitario, SubTotal;

        public DetalleVenta(int ventaid, int productoid, int cantidad, decimal preciounitario, decimal subtotal)
        {
            VentaID = ventaid;
            ProductoID = productoid;
            Cantidad = cantidad;
            PrecioUnitario = preciounitario;
            SubTotal = subtotal;
        }
        public DetalleVenta(int ventaid) 
        {
            VentaID = ventaid;
        }
        //Insertar DetalleVenta
        public void insertarDetalleVenta(SqlConnection con)
        {
            using (SqlCommand comand = new SqlCommand("SP_InsertarDetalleVenta", con))
            {
                comand.CommandType = CommandType.StoredProcedure;

                comand.Parameters.AddWithValue("@VentaID", VentaID);
                comand.Parameters.AddWithValue("@ProductoID", ProductoID);
                comand.Parameters.AddWithValue("@Cantidad", Cantidad);
                comand.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                comand.Parameters.AddWithValue("@Subtotal", SubTotal);

                comand.ExecuteNonQuery();
            }
        }

        public DataTable detalle_Venta(SqlConnection con)
        {
            using (SqlCommand comand = new SqlCommand("SP_ObtenerDetalleVenta", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@VentaID", VentaID);

                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
