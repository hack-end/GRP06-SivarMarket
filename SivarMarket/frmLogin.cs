using SivarMarket;
using SivarMarket.BD;
using SivarMarket.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class frmLogin : Form
    {
        cn conexion = new cn(); // Instancia de la clase de conexión a la base de datos

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Valida los campos y autentica al usuario
            if (ValidarCampos() && AutenticarUsuario(txtUsuario.Text, txtContrasena.Text))
            {
                //Aca haremos la logica para ingresar a los diferentes menus
                if (SesionUsuario.Rol == "Administrador")
                {
                    frmMenu2 menu = new frmMenu2();
                    menu.Show(); // Muestra el formulario del menú principal
                    this.Hide(); // Oculta el formulario de login
                }
                else
                {
                    frmMenu1 menu = new frmMenu1();
                    menu.Show(); // Muestra el formulario del menú principal
                    this.Hide(); // Oculta el formulario de login
                }
                    
                    
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MostrarError("Debe ingresar usuario y contraseña");
                return false;
            }
            return true;
        }


        private bool AutenticarUsuario(string usuario, string contrasena)
        {
            try
            {
                using (SqlConnection con = conexion.Conexion())
                {
                    con.Open(); // Abre la conexión a la base de datos
                    Usuario Usuario = new Usuario(usuario, contrasena);
                    if (Usuario.validarUsuario(con))
                    {
                        // Si la validación es exitosa, se puede continuar con la lógica de inicio de sesión
                        MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MostrarError("Usuario o contraseña incorrectos");
                        return false;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MostrarError($"Error de conexión: {ex.Message}");
                return false;
            }
        }


        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Limpia el campo de contraseña y devuelve el foco al usuario
            txtContrasena.Clear();
            txtUsuario.Focus();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}