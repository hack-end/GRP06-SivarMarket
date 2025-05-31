namespace login
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Lime;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.Location = new System.Drawing.Point(164, 233);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(97, 28);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar ➡";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(267, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar ❌";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(137, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(194, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(137, 64);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(194, 20);
            this.txtContrasena.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(37, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.Location = new System.Drawing.Point(37, 69);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(84, 15);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.grpLogin.Controls.Add(this.txtContrasena);
            this.grpLogin.Controls.Add(this.txtUsuario);
            this.grpLogin.Controls.Add(this.lblContrasena);
            this.grpLogin.Controls.Add(this.lblUsuario);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpLogin.Location = new System.Drawing.Point(67, 128);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(365, 98);
            this.grpLogin.TabIndex = 5;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Inicio de Sesión";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::SivarMarket.Properties.Resources.sivarmarket_removebg_preview;
            this.picLogo.Location = new System.Drawing.Point(94, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(314, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SivarMarket.Properties.Resources.sivarmarketfondo2;
            this.ClientSize = new System.Drawing.Size(502, 364);
            this.ControlBox = false;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sivar-Market";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.PictureBox picLogo;
    }
}