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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCarrito = new System.Windows.Forms.GroupBox();
            this.radAmbos = new System.Windows.Forms.RadioButton();
            this.radEfectivo = new System.Windows.Forms.RadioButton();
            this.radTarjeta = new System.Windows.Forms.RadioButton();
            this.lblMetodoPagar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.CodigoCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitarCarrito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuitarTCarrito = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.dtgCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
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
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(28, 73);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(50, 37);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
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
            this.txtBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProducto.Location = new System.Drawing.Point(68, 16);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(477, 20);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
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
            this.dtgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
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
            this.dtgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellContentClick);
            this.dtgProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgProductos_EditingControlShowing);
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
            this.Cantidad.MaxInputLength = 8;
            this.Cantidad.Name = "Cantidad";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Text = "Agregar";
            this.Accion.UseColumnTextForButtonValue = true;
            this.Accion.Width = 75;
            // 
            // grpCarrito
            // 
            this.grpCarrito.Controls.Add(this.radAmbos);
            this.grpCarrito.Controls.Add(this.radEfectivo);
            this.grpCarrito.Controls.Add(this.radTarjeta);
            this.grpCarrito.Controls.Add(this.lblMetodoPagar);
            this.grpCarrito.Controls.Add(this.btnSalir);
            this.grpCarrito.Controls.Add(this.btnCancelar);
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
            // radAmbos
            // 
            this.radAmbos.AutoSize = true;
            this.radAmbos.Location = new System.Drawing.Point(171, 579);
            this.radAmbos.Name = "radAmbos";
            this.radAmbos.Size = new System.Drawing.Size(57, 17);
            this.radAmbos.TabIndex = 10;
            this.radAmbos.TabStop = true;
            this.radAmbos.Text = "Ambos";
            this.radAmbos.UseVisualStyleBackColor = true;
            // 
            // radEfectivo
            // 
            this.radEfectivo.AutoSize = true;
            this.radEfectivo.Location = new System.Drawing.Point(90, 579);
            this.radEfectivo.Name = "radEfectivo";
            this.radEfectivo.Size = new System.Drawing.Size(64, 17);
            this.radEfectivo.TabIndex = 9;
            this.radEfectivo.TabStop = true;
            this.radEfectivo.Text = "Efectivo";
            this.radEfectivo.UseVisualStyleBackColor = true;
            // 
            // radTarjeta
            // 
            this.radTarjeta.AutoSize = true;
            this.radTarjeta.Checked = true;
            this.radTarjeta.Location = new System.Drawing.Point(9, 579);
            this.radTarjeta.Name = "radTarjeta";
            this.radTarjeta.Size = new System.Drawing.Size(58, 17);
            this.radTarjeta.TabIndex = 8;
            this.radTarjeta.TabStop = true;
            this.radTarjeta.Text = "Tarjeta";
            this.radTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblMetodoPagar
            // 
            this.lblMetodoPagar.AutoSize = true;
            this.lblMetodoPagar.Location = new System.Drawing.Point(6, 531);
            this.lblMetodoPagar.Name = "lblMetodoPagar";
            this.lblMetodoPagar.Size = new System.Drawing.Size(86, 13);
            this.lblMetodoPagar.TabIndex = 7;
            this.lblMetodoPagar.Text = "Metodo de Pago";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(171, 617);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(90, 617);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Location = new System.Drawing.Point(9, 617);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 37);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(265, 545);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(155, 24);
            this.lblTotalPagar.TabIndex = 1;
            this.lblTotalPagar.Text = "Total a pagar: $";
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.AllowUserToAddRows = false;
            this.dtgCarrito.AllowUserToDeleteRows = false;
            this.dtgCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCarrito,
            this.NombreCarrito,
            this.PrecioCarrito,
            this.CantidadCarrito,
            this.SubTotalCarrito,
            this.Quitar_S,
            this.QuitarCarrito,
            this.QuitarTCarrito});
            this.dtgCarrito.Location = new System.Drawing.Point(6, 19);
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.RowHeadersVisible = false;
            this.dtgCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCarrito.Size = new System.Drawing.Size(566, 506);
            this.dtgCarrito.TabIndex = 0;
            this.dtgCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCarrito_CellContentClick);
            this.dtgCarrito.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgCarrito_EditingControlShowing);
            // 
            // CodigoCarrito
            // 
            this.CodigoCarrito.HeaderText = "Codigo";
            this.CodigoCarrito.Name = "CodigoCarrito";
            this.CodigoCarrito.ReadOnly = true;
            this.CodigoCarrito.Width = 60;
            // 
            // NombreCarrito
            // 
            this.NombreCarrito.HeaderText = "Nombre";
            this.NombreCarrito.Name = "NombreCarrito";
            this.NombreCarrito.ReadOnly = true;
            // 
            // PrecioCarrito
            // 
            this.PrecioCarrito.HeaderText = "Precio";
            this.PrecioCarrito.Name = "PrecioCarrito";
            this.PrecioCarrito.ReadOnly = true;
            this.PrecioCarrito.Width = 50;
            // 
            // CantidadCarrito
            // 
            this.CantidadCarrito.HeaderText = "Cantidad";
            this.CantidadCarrito.Name = "CantidadCarrito";
            this.CantidadCarrito.ReadOnly = true;
            this.CantidadCarrito.Width = 60;
            // 
            // SubTotalCarrito
            // 
            this.SubTotalCarrito.HeaderText = "Total";
            this.SubTotalCarrito.Name = "SubTotalCarrito";
            this.SubTotalCarrito.ReadOnly = true;
            this.SubTotalCarrito.Width = 50;
            // 
            // Quitar_S
            // 
            this.Quitar_S.HeaderText = "Cantidad a quitar";
            this.Quitar_S.MaxInputLength = 8;
            this.Quitar_S.Name = "Quitar_S";
            // 
            // QuitarCarrito
            // 
            this.QuitarCarrito.HeaderText = "Quitar";
            this.QuitarCarrito.Name = "QuitarCarrito";
            this.QuitarCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuitarCarrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuitarCarrito.Text = "Quitar";
            this.QuitarCarrito.UseColumnTextForButtonValue = true;
            this.QuitarCarrito.Width = 70;
            // 
            // QuitarTCarrito
            // 
            this.QuitarTCarrito.HeaderText = "Quitar todo";
            this.QuitarTCarrito.Name = "QuitarTCarrito";
            this.QuitarTCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuitarTCarrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuitarTCarrito.Text = "Quitar todos";
            this.QuitarTCarrito.UseColumnTextForButtonValue = true;
            this.QuitarTCarrito.Width = 70;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1175, 685);
            this.Controls.Add(this.grpCarrito);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.grpCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quitar_S;
        private System.Windows.Forms.DataGridViewButtonColumn QuitarCarrito;
        private System.Windows.Forms.DataGridViewButtonColumn QuitarTCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.RadioButton radAmbos;
        private System.Windows.Forms.RadioButton radEfectivo;
        private System.Windows.Forms.RadioButton radTarjeta;
        private System.Windows.Forms.Label lblMetodoPagar;
    }
}