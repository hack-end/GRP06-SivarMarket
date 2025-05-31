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
    public partial class frmSeleccionarCliente : Form
    {
        public string ClienteSeleccionado;
        Cliente cliente = new Cliente();
        cn conexion = new cn();
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();            
        }

        private void cargarDatos()
        {
            using (SqlConnection con = conexion.Conexion())
            {
                try
                {
                    con.Open();
                    dtgClientes.DataSource = cliente.consultarClientesFiltro(con);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los datos de los clientes");
                }
            }
            
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Valida que la columna a la que se le da clic sea la que tiene el boton
            if (e.RowIndex >= 0 && dtgClientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                //Obtener el ID del cliente
                ClienteSeleccionado = dtgClientes.Rows[e.RowIndex].Cells["ClienteID"].Value.ToString();

                //Se cierra el modal indicando que el resultado es OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.ToString().Trim()==string.Empty)
            {
                cargarDatos();
            }
            else
            {
                using (SqlConnection con = conexion.Conexion())
                {
                    try
                    {
                        con.Open();
                        dtgClientes.DataSource = cliente.consultarClienteNombre_Apellido_ID(con, txtBuscar.Text.ToString());
                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.Message);
                        throw;
                    }
                }
            }
                
        }
    }
}
