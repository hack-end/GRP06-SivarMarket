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
    public partial class frmVenta : Form
    {
        Cliente cliente;
        cn conexion = new cn();
        Producto producto;

        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

                if (frmSeleccionarCliente.ShowDialog() == DialogResult.OK)
                {
                    //Aqui ya tenemos el id del cliente
                    int idCliente = Convert.ToInt32(frmSeleccionarCliente.ClienteSeleccionado);
                    cliente = new Cliente(idCliente);
                    //Lo que haremos sera cargar los datos del cliente en nuestro datagidview
                    using (SqlConnection con = conexion.Conexion())
                    {
                        con.Open();
                        dtgCliente.DataSource = cliente.consultarPorID_Venta(con);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            // Cargar datos de productos código, producto(nombre), categoría, precio, stock
            using (SqlConnection con = conexion.Conexion())
            {
                con.Open();
                producto = new Producto();
                dtgProductos.DataSource = producto.ConsultarProductos(con); // Cambiado a método de instancia
            }

            // Permitimos que la celda de Cantidad sí se pueda modificar o escribir dentro
            dtgProductos.Columns["Cantidad"].ReadOnly = false;
        }

        private void dtgProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgProductos.CurrentCell.ColumnIndex == dtgProductos.Columns["Cantidad"].Index)
            {
                TextBox txtEdit = e.Control as TextBox;
                if (txtEdit != null)
                {
                    txtEdit.KeyPress -= soloNumeros_KeyPress;
                    txtEdit.KeyPress += soloNumeros_KeyPress;
                }
            }
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}