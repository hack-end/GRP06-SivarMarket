using SivarMarket.BD;
using SivarMarket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SivarMarket
{
    public partial class frmDetallePago : Form
    {
        DetalleVenta detalleVenta;
        Venta venta;
        cn conexion = new cn();
        decimal pagar;
        public frmDetallePago(int VentaID)
        {
            string algo = "hola";
            detalleVenta = new DetalleVenta(VentaID);
            venta = new Venta(VentaID , algo);
            InitializeComponent();
        }

        private void frmDetallePago_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
                


            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los detalles de la venta");
                throw;
            }
        }
        private void cargarDatos()
        {
            using (SqlConnection con = conexion.Conexion())
            {
                con.Open();
                dtgDetalle.DataSource = detalleVenta.detalle_Venta(con);
                
                DataTable dtVenta = venta.ObtenerDatosVenta(con);
                if (dtVenta.Rows.Count > 0)
                {
                    DataRow row = dtVenta.Rows[0];
                    lblNumFactura.Text = row["VentaID"].ToString();
                    lblNombreCliente.Text = row["NombreCliente"].ToString();
                    lblNombreVendedor.Text = row["NombreUsuario"].ToString();
                    lblFechaVenta.Text = Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy");
                    lblTotalCalculado.Text = Convert.ToDecimal(row["Total"]).ToString("C");
                    lblMetodoPagado.Text = row["MetodoPago"].ToString();
                    numVuelto.Minimum = Convert.ToDecimal(row["Total"]);
                    pagar = Convert.ToDecimal(row["Total"]);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para esta venta.");
                }
            
                }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal vuelto = Convert.ToDecimal(numVuelto.Value.ToString());
            vuelto = vuelto - pagar;
            lblVueltoDar.Text = vuelto.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
