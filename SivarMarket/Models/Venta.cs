using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SivarMarket.Models
{
    internal class Venta
    {
        //Atributos de la clase
        private int VentaID, ClienteID, UsuarioID;
        private DateTime FechaVenta;
        private decimal Total, Impuesto;
        private string MetodoPago;

        //Constructores
        public Venta() { }
        public Venta(int VentaID, string dato) 
        {
            this.VentaID = VentaID;
        }
        public Venta (int clienteid)
        {
            ClienteID = clienteid;
        }

        public Venta(int clienteid, int usuarioid, DateTime fechaventa, decimal total, decimal impuesto, string metodopago)
        {
            ClienteID = clienteid;
            UsuarioID = usuarioid;
            FechaVenta = fechaventa;
            Total = total;
            Impuesto = impuesto;
            MetodoPago = metodopago;
        }

        //Consultas

        //Consulta para buscar un cliente entre las ventas
        public bool buscarClienteVenta(SqlConnection con)
        {
            using (SqlCommand comand = new SqlCommand("SP_BuscarClienteVenta", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@ClienteID", ClienteID);

                int cantidad = Convert.ToInt32(comand.ExecuteScalar());

                return cantidad > 0;
            }
        }

        //Insertar una venta
        public void insertarVenta(SqlConnection con)
        {
            using (SqlCommand comand = new SqlCommand("SP_InsertarVenta", con))
            {
                comand.CommandType = CommandType.StoredProcedure;

                comand.Parameters.AddWithValue("@ClienteID", ClienteID);
                comand.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                comand.Parameters.AddWithValue("@FechaVenta", FechaVenta);
                comand.Parameters.AddWithValue("@Total", Total);
                comand.Parameters.AddWithValue("@Impuesto", Impuesto);
                comand.Parameters.AddWithValue("@MetodoPago", MetodoPago);

                SqlParameter paramVentaID = new SqlParameter("@VentaID", SqlDbType.Int);
                paramVentaID.Direction = ParameterDirection.Output;
                comand.Parameters.Add(paramVentaID);
                comand.ExecuteNonQuery();
                VentaID = Convert.ToInt32(paramVentaID.Value);
            }
        }
        public int devolverVentaID()
        {
            return VentaID;
        }


        //Usado para buscar el historial de ventas
        public DataTable historicoVentas(SqlConnection con, string busqueda)
        {
            using (SqlCommand comand = new SqlCommand("SP_BuscarHistorialVentas", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@Busqueda", string.IsNullOrWhiteSpace(busqueda)?(object)DBNull.Value:busqueda);

                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Usado para sacar los datos de los implicados en la venta (comprador, vendedor), num factura, total, fecha
        public DataTable ObtenerDatosVenta(SqlConnection con)
        {
            DataTable dt = new DataTable();
            using (SqlCommand comand = new SqlCommand("SP_ObtenerVentaPorID", con))
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@VentaID", VentaID);

                using (SqlDataReader reader = comand.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
