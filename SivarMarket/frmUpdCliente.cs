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
    public partial class frmUpdCliente : Form
    {
        private int clienteID;
        cn conexion=new cn();
        Cliente cliente;
        public frmUpdCliente(int id)
        {
            InitializeComponent();
            this.clienteID = id;
        }

        private void frmUpdCliente_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = conexion.Conexion())
            {
                con.Open();
                cliente = new Cliente();
                DataTable dt = cliente.consultarPorID(con,clienteID);

                if (dt.Rows.Count > 0) 
                {
                    txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                    txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                    mktTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                    txtCorreo.Text = dt.Rows[0]["Correo"].ToString();
                    txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.ToString().Trim() == string.Empty || txtApellido.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("No deje el campo de Nombre o Apellido vacio", "NOTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre= txtNombre.Text.ToString().Trim();
                string apellido = txtApellido.Text.ToString().Trim();
                string telefono = mktTelefono.Text.ToString().Trim();
                string correo = txtCorreo.Text.ToString().Trim();
                string direccion = txtDireccion.Text.ToString().Trim();                
                using (SqlConnection con = conexion.Conexion())
                {
                    Cliente cliente = new Cliente(clienteID, nombre, apellido, telefono, correo, direccion);
                    con.Open();
                    cliente.actualizarCliente(con);
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
