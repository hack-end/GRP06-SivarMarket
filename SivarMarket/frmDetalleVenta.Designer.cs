namespace SivarMarket
{
    partial class frmDetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVenta));
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.DetalleVentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.btnVolver);
            this.grpDetalles.Controls.Add(this.dtgDetalle);
            this.grpDetalles.Location = new System.Drawing.Point(13, 13);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(457, 609);
            this.grpDetalles.TabIndex = 0;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Productos ";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(6, 553);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 50);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleVentaID,
            this.ProductoNombre,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.dtgDetalle.Location = new System.Drawing.Point(6, 20);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersVisible = false;
            this.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalle.Size = new System.Drawing.Size(445, 527);
            this.dtgDetalle.TabIndex = 0;
            // 
            // DetalleVentaID
            // 
            this.DetalleVentaID.DataPropertyName = "DetalleVentaID";
            this.DetalleVentaID.HeaderText = "ID";
            this.DetalleVentaID.Name = "DetalleVentaID";
            this.DetalleVentaID.ReadOnly = true;
            this.DetalleVentaID.Width = 50;
            // 
            // ProductoNombre
            // 
            this.ProductoNombre.DataPropertyName = "ProductoNombre";
            this.ProductoNombre.HeaderText = "Producto";
            this.ProductoNombre.Name = "ProductoNombre";
            this.ProductoNombre.ReadOnly = true;
            this.ProductoNombre.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "Precio C/U";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 70;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "Subtotal";
            this.SubTotal.HeaderText = "Subtotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 60;
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(483, 634);
            this.Controls.Add(this.grpDetalles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            this.grpDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleVentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}