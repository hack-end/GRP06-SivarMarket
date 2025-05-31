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
    public partial class frmCliente : Form
    {
        //Creamos un objeto de la clase cn que tiene la conexion a la base de datos
        cn conexion = new cn();
        Cliente cliente;
        
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {            
            
           cargarDatos();
        }
        private void cargarDatos()
        {
            try
            {
                cliente = new Cliente();
                //Cargamos los datos al dataGridView
                using (SqlConnection con = conexion.Conexion())
                {
                    con.Open();
                    dtgClientes.DataSource = cliente.consultarClientes(con);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de clientes");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.ToString().Trim() == string.Empty || txtApellido.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("No dejar el nombre o el apellido vacios", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else {
                cliente = new Cliente(txtNombre.Text.ToString().Trim(), txtApellido.Text.ToString().Trim(), mktTelefono.Text.ToString().Trim(), txtCorreo.Text.ToString().Trim(), txtDireccion.Text.ToString().Trim());
                using (SqlConnection con = conexion.Conexion())
                {
                    con.Open();
                    cliente.insertarCliente(con);
                }

                cargarDatos();
                limpiarCampos();
                
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            mktTelefono.Text = string.Empty;

            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                int clienteID = Convert.ToInt32(dtgClientes.SelectedRows[0].Cells["ClienteID"].Value);

                frmUpdCliente frm = new frmUpdCliente(clienteID);
                frm.ShowDialog();

                cargarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione el cliente al que desea actulizar sus datos","Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                int clienteID = Convert.ToInt32(dtgClientes.SelectedRows[0].Cells["ClienteID"].Value);
                
                //Instanciamos los objetos
                Venta  venta = new Venta(clienteID);
                Cliente cliente = new Cliente(clienteID);

                using (SqlConnection con = conexion.Conexion())
                {
                    con.Open();
                    //Si lo que devuelve es true no se puede eliminar
                    if (venta.buscarClienteVenta(con) == true)
                    {
                        MessageBox.Show("No puede eliminar este cliente, primero elimine el registro de su venta si desea eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Se elimina ya que nunca se utilizo este cliente para una venta
                        cliente.eliminarCliente(con);
                        cargarDatos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el cliente al que desea actulizar sus datos", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                cargarDatos();
            }
            else
            {
                using (SqlConnection con = conexion.Conexion())
                {
                    cliente = new Cliente();
                    dtgClientes.DataSource = cliente.consultarClientesFiltro(con, txtBuscar.Text.ToString());
                }                
            }
        }
    }
}
