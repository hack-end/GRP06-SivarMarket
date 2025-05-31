namespace SivarMarket
{
    partial class frmDetallePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallePago));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblMetodoPagado = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.DetalleVentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grpVuelto = new System.Windows.Forms.GroupBox();
            this.lblVueltoDar = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCantidadDada = new System.Windows.Forms.Label();
            this.numVuelto = new System.Windows.Forms.NumericUpDown();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.grpVuelto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVuelto)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblMetodoPagado);
            this.grpDatos.Controls.Add(this.lblMetodoPago);
            this.grpDatos.Controls.Add(this.lblNumFactura);
            this.grpDatos.Controls.Add(this.lblFactura);
            this.grpDatos.Controls.Add(this.lblTotalCalculado);
            this.grpDatos.Controls.Add(this.lblTotal);
            this.grpDatos.Controls.Add(this.dtgDetalle);
            this.grpDatos.Controls.Add(this.lblFechaVenta);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.lblNombreVendedor);
            this.grpDatos.Controls.Add(this.lblVendedor);
            this.grpDatos.Controls.Add(this.lblNombreCliente);
            this.grpDatos.Controls.Add(this.lblCliente);
            this.grpDatos.Location = new System.Drawing.Point(12, 13);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(460, 650);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblMetodoPagado
            // 
            this.lblMetodoPagado.AutoSize = true;
            this.lblMetodoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPagado.Location = new System.Drawing.Point(369, 20);
            this.lblMetodoPagado.Name = "lblMetodoPagado";
            this.lblMetodoPagado.Size = new System.Drawing.Size(0, 16);
            this.lblMetodoPagado.TabIndex = 12;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(246, 20);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(104, 16);
            this.lblMetodoPago.TabIndex = 11;
            this.lblMetodoPago.Text = "Metodo Pago:";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(108, 16);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(0, 20);
            this.lblNumFactura.TabIndex = 10;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(7, 16);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(86, 20);
            this.lblFactura.TabIndex = 9;
            this.lblFactura.Text = "Factura #";
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalculado.Location = new System.Drawing.Point(363, 98);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(0, 16);
            this.lblTotalCalculado.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(296, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
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
            this.dtgDetalle.Location = new System.Drawing.Point(6, 117);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersVisible = false;
            this.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalle.Size = new System.Drawing.Size(448, 527);
            this.dtgDetalle.TabIndex = 6;
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
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(363, 58);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(0, 16);
            this.lblFechaVenta.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(296, 58);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(98, 87);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(0, 16);
            this.lblNombreVendedor.TabIndex = 3;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(7, 87);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(79, 16);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(98, 58);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.lblNombreCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(7, 58);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // grpVuelto
            // 
            this.grpVuelto.Controls.Add(this.lblVueltoDar);
            this.grpVuelto.Controls.Add(this.lblVuelto);
            this.grpVuelto.Controls.Add(this.btnCalcular);
            this.grpVuelto.Controls.Add(this.lblCantidadDada);
            this.grpVuelto.Controls.Add(this.numVuelto);
            this.grpVuelto.Location = new System.Drawing.Point(480, 13);
            this.grpVuelto.Name = "grpVuelto";
            this.grpVuelto.Size = new System.Drawing.Size(236, 526);
            this.grpVuelto.TabIndex = 1;
            this.grpVuelto.TabStop = false;
            this.grpVuelto.Text = "Calcular Vuelto";
            // 
            // lblVueltoDar
            // 
            this.lblVueltoDar.AutoSize = true;
            this.lblVueltoDar.Location = new System.Drawing.Point(61, 346);
            this.lblVueltoDar.Name = "lblVueltoDar";
            this.lblVueltoDar.Size = new System.Drawing.Size(0, 13);
            this.lblVueltoDar.TabIndex = 6;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(6, 346);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(49, 13);
            this.lblVuelto.TabIndex = 5;
            this.lblVuelto.Text = "Vuelto: $";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(76, 191);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(73, 31);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCantidadDada
            // 
            this.lblCantidadDada.AutoSize = true;
            this.lblCantidadDada.Location = new System.Drawing.Point(73, 96);
            this.lblCantidadDada.Name = "lblCantidadDada";
            this.lblCantidadDada.Size = new System.Drawing.Size(76, 13);
            this.lblCantidadDada.TabIndex = 1;
            this.lblCantidadDada.Text = "Cantidad dada";
            // 
            // numVuelto
            // 
            this.numVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.numVuelto.DecimalPlaces = 2;
            this.numVuelto.Location = new System.Drawing.Point(43, 134);
            this.numVuelto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numVuelto.Name = "numVuelto";
            this.numVuelto.Size = new System.Drawing.Size(132, 20);
            this.numVuelto.TabIndex = 0;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnVolver);
            this.grpAcciones.Location = new System.Drawing.Point(478, 545);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(236, 112);
            this.grpAcciones.TabIndex = 2;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Accion";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(78, 33);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 48);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmDetallePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(728, 675);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpVuelto);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetallePago";
            this.Text = "Detalle del Pago";
            this.Load += new System.EventHandler(this.frmDetallePago_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.grpVuelto.ResumeLayout(false);
            this.grpVuelto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVuelto)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleVentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpVuelto;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblMetodoPagado;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblCantidadDada;
        private System.Windows.Forms.NumericUpDown numVuelto;
        private System.Windows.Forms.Label lblVueltoDar;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Button btnCalcular;
    }
}