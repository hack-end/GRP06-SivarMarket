namespace SivarMarket
{
    partial class frmVenta
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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelecCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.grpCarrito = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBuscarCarrito = new System.Windows.Forms.TextBox();
            this.lblBuscarCarrito = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.grpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.grpCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.dtgCliente);
            this.grpCliente.Controls.Add(this.lblSelecCliente);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(568, 147);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.nombreCompleto,
            this.Telefono,
            this.Correo,
            this.Direccion});
            this.dtgCliente.Location = new System.Drawing.Point(125, 16);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(437, 125);
            this.dtgCliente.TabIndex = 2;
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "ClienteID";
            this.ClienteID.HeaderText = "ID";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            this.ClienteID.Width = 26;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.DataPropertyName = "Nombre_Completo";
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 60;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 77;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 120;
            // 
            // lblSelecCliente
            // 
            this.lblSelecCliente.AutoSize = true;
            this.lblSelecCliente.Location = new System.Drawing.Point(6, 57);
            this.lblSelecCliente.Name = "lblSelecCliente";
            this.lblSelecCliente.Size = new System.Drawing.Size(97, 13);
            this.lblSelecCliente.TabIndex = 1;
            this.lblSelecCliente.Text = "Seleccionar cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(28, 73);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(50, 37);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // grpProductos
            // 
            this.grpProductos.Controls.Add(this.txtBuscarProducto);
            this.grpProductos.Controls.Add(this.lblBuscarProducto);
            this.grpProductos.Controls.Add(this.dtgProductos);
            this.grpProductos.Location = new System.Drawing.Point(13, 165);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(567, 508);
            this.grpProductos.TabIndex = 1;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Productos";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(68, 16);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(477, 20);
            this.txtBuscarProducto.TabIndex = 2;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Location = new System.Drawing.Point(6, 19);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarProducto.TabIndex = 1;
            this.lblBuscarProducto.Text = "Buscar:";
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Precio,
            this.Stock,
            this.Cantidad,
            this.Accion});
            this.dtgProductos.Location = new System.Drawing.Point(8, 42);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersVisible = false;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(553, 460);
            this.dtgProductos.TabIndex = 0;
            this.dtgProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgProductos_EditingControlShowing);
            // 
            // grpCarrito
            // 
            this.grpCarrito.Controls.Add(this.btnSalir);
            this.grpCarrito.Controls.Add(this.btnCancelar);
            this.grpCarrito.Controls.Add(this.txtBuscarCarrito);
            this.grpCarrito.Controls.Add(this.lblBuscarCarrito);
            this.grpCarrito.Controls.Add(this.btnPagar);
            this.grpCarrito.Controls.Add(this.lblTotalPagar);
            this.grpCarrito.Controls.Add(this.dtgCarrito);
            this.grpCarrito.Location = new System.Drawing.Point(586, 13);
            this.grpCarrito.Name = "grpCarrito";
            this.grpCarrito.Size = new System.Drawing.Size(578, 660);
            this.grpCarrito.TabIndex = 2;
            this.grpCarrito.TabStop = false;
            this.grpCarrito.Text = "Carrito";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(472, 606);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 606);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCarrito
            // 
            this.txtBuscarCarrito.Location = new System.Drawing.Point(78, 30);
            this.txtBuscarCarrito.Name = "txtBuscarCarrito";
            this.txtBuscarCarrito.Size = new System.Drawing.Size(494, 20);
            this.txtBuscarCarrito.TabIndex = 4;
            // 
            // lblBuscarCarrito
            // 
            this.lblBuscarCarrito.AutoSize = true;
            this.lblBuscarCarrito.Location = new System.Drawing.Point(6, 33);
            this.lblBuscarCarrito.Name = "lblBuscarCarrito";
            this.lblBuscarCarrito.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarCarrito.TabIndex = 3;
            this.lblBuscarCarrito.Text = "Buscar:";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(310, 606);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 37);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(6, 610);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(155, 24);
            this.lblTotalPagar.TabIndex = 1;
            this.lblTotalPagar.Text = "Total a pagar: $";
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarrito.Location = new System.Drawing.Point(6, 56);
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.RowHeadersVisible = false;
            this.dtgCarrito.Size = new System.Drawing.Size(566, 529);
            this.dtgCarrito.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Producto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Text = "Agregar";
            this.Accion.UseColumnTextForButtonValue = true;
            this.Accion.Width = 75;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 685);
            this.Controls.Add(this.grpCarrito);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.grpCliente);
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.grpCarrito.ResumeLayout(false);
            this.grpCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.GroupBox grpCarrito;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label lblSelecCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView dtgCarrito;
        private System.Windows.Forms.TextBox txtBuscarCarrito;
        private System.Windows.Forms.Label lblBuscarCarrito;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}