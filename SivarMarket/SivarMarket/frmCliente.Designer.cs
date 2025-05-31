namespace SivarMarket
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mktTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtCorreo);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.mktTelefono);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(289, 309);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(10, 169);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(273, 20);
            this.txtCorreo.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 52);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 251);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 52);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(10, 212);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(273, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // mktTelefono
            // 
            this.mktTelefono.Location = new System.Drawing.Point(10, 126);
            this.mktTelefono.Mask = "0000-0000";
            this.mktTelefono.Name = "mktTelefono";
            this.mktTelefono.Size = new System.Drawing.Size(63, 20);
            this.mktTelefono.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(10, 81);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(273, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.dtgClientes);
            this.grpClientes.Location = new System.Drawing.Point(307, 12);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(704, 309);
            this.grpClientes.TabIndex = 1;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "Clientes";
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Correo,
            this.Direccion});
            this.dtgClientes.Location = new System.Drawing.Point(7, 20);
            this.dtgClientes.MultiSelect = false;
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(691, 283);
            this.dtgClientes.TabIndex = 0;
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "ClienteID";
            this.ClienteID.HeaderText = "ID";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            this.ClienteID.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 90;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 235;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnDarBaja);
            this.grpAcciones.Controls.Add(this.btnActualizar);
            this.grpAcciones.Location = new System.Drawing.Point(307, 327);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(704, 87);
            this.grpAcciones.TabIndex = 2;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(471, 19);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(71, 53);
            this.btnDarBaja.TabIndex = 9;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(229, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(71, 53);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 426);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpClientes);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mktTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}

