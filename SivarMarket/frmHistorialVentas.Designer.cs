namespace SivarMarket
{
    partial class frmHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialVentas));
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dtgHistorial = new System.Windows.Forms.DataGridView();
            this.VentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.dtgHistorial);
            this.grpHistorial.Controls.Add(this.txtBuscar);
            this.grpHistorial.Controls.Add(this.lblBuscar);
            this.grpHistorial.Location = new System.Drawing.Point(13, 13);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(916, 614);
            this.grpHistorial.TabIndex = 0;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial Ventas";
            // 
            // dtgHistorial
            // 
            this.dtgHistorial.AllowUserToAddRows = false;
            this.dtgHistorial.AllowUserToDeleteRows = false;
            this.dtgHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.dtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VentaID,
            this.NombreCiente,
            this.NombreUsuario,
            this.Fecha,
            this.Total,
            this.MetodoPago,
            this.Detalles});
            this.dtgHistorial.Location = new System.Drawing.Point(6, 43);
            this.dtgHistorial.Name = "dtgHistorial";
            this.dtgHistorial.ReadOnly = true;
            this.dtgHistorial.RowHeadersVisible = false;
            this.dtgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistorial.Size = new System.Drawing.Size(904, 565);
            this.dtgHistorial.TabIndex = 2;
            this.dtgHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHistorial_CellContentClick);
            // 
            // VentaID
            // 
            this.VentaID.DataPropertyName = "VentaID";
            this.VentaID.HeaderText = "ID";
            this.VentaID.Name = "VentaID";
            this.VentaID.ReadOnly = true;
            this.VentaID.Width = 50;
            // 
            // NombreCiente
            // 
            this.NombreCiente.DataPropertyName = "NombreCliente";
            this.NombreCiente.HeaderText = "Cliente";
            this.NombreCiente.Name = "NombreCiente";
            this.NombreCiente.ReadOnly = true;
            this.NombreCiente.Width = 225;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "NombreUsuario";
            this.NombreUsuario.HeaderText = "Vendedor";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 225;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 105;
            // 
            // MetodoPago
            // 
            this.MetodoPago.DataPropertyName = "MetodoPago";
            this.MetodoPago.HeaderText = "Metodo Pago";
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.ReadOnly = true;
            this.MetodoPago.Width = 95;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalle Venta";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Text = "Detalles";
            this.Detalles.UseColumnTextForButtonValue = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(56, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(455, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(7, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // frmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.grpHistorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.frmHistorialVentas_Load);
            this.grpHistorial.ResumeLayout(false);
            this.grpHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dtgHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoPago;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
    }
}