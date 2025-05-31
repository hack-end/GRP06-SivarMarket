using login;
using SivarMarket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SivarMarket
{
    public partial class frmMenu1 : Form
    {
        public frmMenu1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta frmVenta = new frmVenta();
            frmVenta.Show();
        }

        private void historialVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialVentas frmHistorialVentas = new frmHistorialVentas();
            frmHistorialVentas.Show();
        }

        private void cerrarSesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SesionUsuario.UsuarioId = 0;
            SesionUsuario.Rol = string.Empty;
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
