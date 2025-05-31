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
    public partial class frmHistorialVentas : Form
    {
        cn conexion = new cn();
        Venta venta = new Venta();
        public frmHistorialVentas()
        {
            InitializeComponent();
        }

        private void frmHistorialVentas_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el historial de ventas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarDatos()
        {
            using (SqlConnection con = conexion.Conexion())
            {
                con.Open();
                dtgHistorial.DataSource = venta.historicoVentas(con, txtBuscar.Text.ToString().Trim());
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex == dtgHistorial.Columns["Detalles"].Index) 
            {
                int VentaID = Convert.ToInt32(dtgHistorial.Rows[e.RowIndex].Cells["VentaID"].Value);
                frmDetalleVenta frmDetalleVenta = new frmDetalleVenta(VentaID);
                frmDetalleVenta.ShowDialog();
            }
        }
    }
}
