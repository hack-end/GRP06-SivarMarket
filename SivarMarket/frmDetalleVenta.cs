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
    public partial class frmDetalleVenta : Form
    {
        cn conexion = new cn();
        DetalleVenta detalleVenta;
        public frmDetalleVenta(int ventaID)
        {
            detalleVenta = new DetalleVenta(ventaID);
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de detalle venta", "Error", MessageBoxButtons.OK);
            }

        }

        private void cargarDatos()
        {
            using (SqlConnection con = conexion.Conexion())
            {
                con.Open();
                dtgDetalle.DataSource = detalleVenta.detalle_Venta(con);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
