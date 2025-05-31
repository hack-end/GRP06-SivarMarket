namespace SivarMarket.Forms.Products
{
    partial class frmAdminProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminProductos));
            this.grpDatosCatalogo = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabListado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscCateg = new System.Windows.Forms.TextBox();
            this.grpAgregar = new System.Windows.Forms.GroupBox();
            this.lblDescCat = new System.Windows.Forms.Label();
            this.lblCatNombre = new System.Windows.Forms.Label();
            this.txtNombreCateg = new System.Windows.Forms.TextBox();
            this.btnLimpiarCat = new System.Windows.Forms.Button();
            this.txtDescpCateg = new System.Windows.Forms.TextBox();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgAgregProd = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboCategProd = new System.Windows.Forms.ComboBox();
            this.txtStockProd = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.txtDescripProd = new System.Windows.Forms.TextBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.btnLimpProd = new System.Windows.Forms.Button();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpDatosCatalogo.SuspendLayout();
            this.tabListado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpAgregar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgregProd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosCatalogo
            // 
            this.grpDatosCatalogo.Controls.Add(this.lblCategoria);
            this.grpDatosCatalogo.Controls.Add(this.lblBuscar);
            this.grpDatosCatalogo.Controls.Add(this.btnLimpiar);
            this.grpDatosCatalogo.Controls.Add(this.btnBuscar);
            this.grpDatosCatalogo.Controls.Add(this.cboCategoria);
            this.grpDatosCatalogo.Controls.Add(this.txtBuscar);
            this.grpDatosCatalogo.Location = new System.Drawing.Point(40, 15);
            this.grpDatosCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosCatalogo.Name = "grpDatosCatalogo";
            this.grpDatosCatalogo.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosCatalogo.Size = new System.Drawing.Size(586, 176);
            this.grpDatosCatalogo.TabIndex = 0;
            this.grpDatosCatalogo.TabStop = false;
            this.grpDatosCatalogo.Text = "Datos de busqueda";
            this.grpDatosCatalogo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(284, 55);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(50, 55);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(308, 108);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 32);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(176, 108);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(348, 53);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(114, 21);
            this.cboCategoria.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(112, 50);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(114, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // tabListado
            // 
            this.tabListado.AccessibleDescription = "";
            this.tabListado.AccessibleName = "";
            this.tabListado.Controls.Add(this.tabPage1);
            this.tabListado.Controls.Add(this.tabPage2);
            this.tabListado.Controls.Add(this.tabPage3);
            this.tabListado.Location = new System.Drawing.Point(29, 24);
            this.tabListado.Margin = new System.Windows.Forms.Padding(2);
            this.tabListado.Name = "tabListado";
            this.tabListado.SelectedIndex = 0;
            this.tabListado.Size = new System.Drawing.Size(674, 389);
            this.tabListado.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.tabPage1.Controls.Add(this.dtgProductos);
            this.tabPage1.Controls.Add(this.grpDatosCatalogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(666, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Productos";
            // 
            // dtgProductos
            // 
            this.dtgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductos.Location = new System.Drawing.Point(44, 209);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.RowTemplate.Height = 24;
            this.dtgProductos.Size = new System.Drawing.Size(584, 146);
            this.dtgProductos.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.tabPage2.Controls.Add(this.dtgCategorias);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.grpAgregar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(666, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCategorias.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCategorias.Location = new System.Drawing.Point(13, 178);
            this.dtgCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCategorias.Name = "dtgCategorias";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCategorias.RowHeadersWidth = 51;
            this.dtgCategorias.RowTemplate.Height = 24;
            this.dtgCategorias.Size = new System.Drawing.Size(650, 170);
            this.dtgCategorias.TabIndex = 2;
            this.dtgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbuscCateg);
            this.groupBox1.Location = new System.Drawing.Point(350, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(314, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnBuscarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCat.Location = new System.Drawing.Point(114, 91);
            this.btnBuscarCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(68, 26);
            this.btnBuscarCat.TabIndex = 7;
            this.btnBuscarCat.Text = "Buscar";
            this.btnBuscarCat.UseVisualStyleBackColor = false;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // txtbuscCateg
            // 
            this.txtbuscCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtbuscCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscCateg.Location = new System.Drawing.Point(85, 47);
            this.txtbuscCateg.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscCateg.Name = "txtbuscCateg";
            this.txtbuscCateg.Size = new System.Drawing.Size(144, 20);
            this.txtbuscCateg.TabIndex = 7;
            // 
            // grpAgregar
            // 
            this.grpAgregar.Controls.Add(this.lblDescCat);
            this.grpAgregar.Controls.Add(this.lblCatNombre);
            this.grpAgregar.Controls.Add(this.txtNombreCateg);
            this.grpAgregar.Controls.Add(this.btnLimpiarCat);
            this.grpAgregar.Controls.Add(this.txtDescpCateg);
            this.grpAgregar.Controls.Add(this.btnAgregarCat);
            this.grpAgregar.Location = new System.Drawing.Point(11, 17);
            this.grpAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.grpAgregar.Name = "grpAgregar";
            this.grpAgregar.Padding = new System.Windows.Forms.Padding(2);
            this.grpAgregar.Size = new System.Drawing.Size(322, 147);
            this.grpAgregar.TabIndex = 0;
            this.grpAgregar.TabStop = false;
            this.grpAgregar.Text = "Agregar";
            // 
            // lblDescCat
            // 
            this.lblDescCat.AutoSize = true;
            this.lblDescCat.Location = new System.Drawing.Point(13, 69);
            this.lblDescCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescCat.Name = "lblDescCat";
            this.lblDescCat.Size = new System.Drawing.Size(63, 13);
            this.lblDescCat.TabIndex = 6;
            this.lblDescCat.Text = "Descripcion";
            // 
            // lblCatNombre
            // 
            this.lblCatNombre.AutoSize = true;
            this.lblCatNombre.Location = new System.Drawing.Point(13, 37);
            this.lblCatNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatNombre.Name = "lblCatNombre";
            this.lblCatNombre.Size = new System.Drawing.Size(44, 13);
            this.lblCatNombre.TabIndex = 5;
            this.lblCatNombre.Text = "Nombre";
            // 
            // txtNombreCateg
            // 
            this.txtNombreCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtNombreCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCateg.Location = new System.Drawing.Point(85, 34);
            this.txtNombreCateg.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCateg.Name = "txtNombreCateg";
            this.txtNombreCateg.Size = new System.Drawing.Size(158, 20);
            this.txtNombreCateg.TabIndex = 4;
            // 
            // btnLimpiarCat
            // 
            this.btnLimpiarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnLimpiarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCat.Location = new System.Drawing.Point(164, 103);
            this.btnLimpiarCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCat.Name = "btnLimpiarCat";
            this.btnLimpiarCat.Size = new System.Drawing.Size(68, 26);
            this.btnLimpiarCat.TabIndex = 3;
            this.btnLimpiarCat.Text = "Limpiar";
            this.btnLimpiarCat.UseVisualStyleBackColor = false;
            this.btnLimpiarCat.Click += new System.EventHandler(this.btnLimpiarCat_Click);
            // 
            // txtDescpCateg
            // 
            this.txtDescpCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtDescpCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescpCateg.Location = new System.Drawing.Point(85, 64);
            this.txtDescpCateg.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescpCateg.Name = "txtDescpCateg";
            this.txtDescpCateg.Size = new System.Drawing.Size(158, 20);
            this.txtDescpCateg.TabIndex = 2;
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCat.Location = new System.Drawing.Point(75, 103);
            this.btnAgregarCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(68, 26);
            this.btnAgregarCat.TabIndex = 0;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.tabPage3.Controls.Add(this.dtgAgregProd);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(666, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            // 
            // dtgAgregProd
            // 
            this.dtgAgregProd.AllowUserToAddRows = false;
            this.dtgAgregProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAgregProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgAgregProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAgregProd.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgAgregProd.Location = new System.Drawing.Point(9, 179);
            this.dtgAgregProd.Margin = new System.Windows.Forms.Padding(2);
            this.dtgAgregProd.Name = "dtgAgregProd";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAgregProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgAgregProd.RowHeadersWidth = 51;
            this.dtgAgregProd.RowTemplate.Height = 24;
            this.dtgAgregProd.Size = new System.Drawing.Size(650, 170);
            this.dtgAgregProd.TabIndex = 5;
            this.dtgAgregProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgregProd_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecioProd);
            this.groupBox3.Controls.Add(this.lblPrecio);
            this.groupBox3.Controls.Add(this.cboCategProd);
            this.groupBox3.Controls.Add(this.txtStockProd);
            this.groupBox3.Controls.Add(this.lblStock);
            this.groupBox3.Controls.Add(this.lblPrecioProd);
            this.groupBox3.Controls.Add(this.lblDescProd);
            this.groupBox3.Controls.Add(this.txtDescripProd);
            this.groupBox3.Controls.Add(this.lblNombreProd);
            this.groupBox3.Controls.Add(this.lblCodProd);
            this.groupBox3.Controls.Add(this.txtCodProd);
            this.groupBox3.Controls.Add(this.btnLimpProd);
            this.groupBox3.Controls.Add(this.txtNombreProd);
            this.groupBox3.Controls.Add(this.btnAgregarProd);
            this.groupBox3.Location = new System.Drawing.Point(8, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(652, 147);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtPrecioProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioProd.Location = new System.Drawing.Point(366, 69);
            this.txtPrecioProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(146, 20);
            this.txtPrecioProd.TabIndex = 15;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(310, 69);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // cboCategProd
            // 
            this.cboCategProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.cboCategProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategProd.FormattingEnabled = true;
            this.cboCategProd.Location = new System.Drawing.Point(366, 28);
            this.cboCategProd.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategProd.Name = "cboCategProd";
            this.cboCategProd.Size = new System.Drawing.Size(146, 21);
            this.cboCategProd.TabIndex = 13;
            // 
            // txtStockProd
            // 
            this.txtStockProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtStockProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockProd.Location = new System.Drawing.Point(366, 105);
            this.txtStockProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockProd.Name = "txtStockProd";
            this.txtStockProd.Size = new System.Drawing.Size(146, 20);
            this.txtStockProd.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(310, 107);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Location = new System.Drawing.Point(310, 32);
            this.lblPrecioProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(52, 13);
            this.lblPrecioProd.TabIndex = 10;
            this.lblPrecioProd.Text = "Categoria";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(13, 105);
            this.lblDescProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(63, 13);
            this.lblDescProd.TabIndex = 8;
            this.lblDescProd.Text = "Descripcion";
            // 
            // txtDescripProd
            // 
            this.txtDescripProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtDescripProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripProd.Location = new System.Drawing.Point(112, 100);
            this.txtDescripProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripProd.Name = "txtDescripProd";
            this.txtDescripProd.Size = new System.Drawing.Size(158, 20);
            this.txtDescripProd.TabIndex = 7;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(13, 69);
            this.lblNombreProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProd.TabIndex = 6;
            this.lblNombreProd.Text = "Nombre";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(13, 37);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(101, 13);
            this.lblCodProd.TabIndex = 5;
            this.lblCodProd.Text = "Codigo de Producto";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProd.Location = new System.Drawing.Point(112, 32);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(158, 20);
            this.txtCodProd.TabIndex = 4;
            // 
            // btnLimpProd
            // 
            this.btnLimpProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnLimpProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpProd.Location = new System.Drawing.Point(550, 28);
            this.btnLimpProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpProd.Name = "btnLimpProd";
            this.btnLimpProd.Size = new System.Drawing.Size(68, 26);
            this.btnLimpProd.TabIndex = 3;
            this.btnLimpProd.Text = "Limpiar";
            this.btnLimpProd.UseVisualStyleBackColor = false;
            this.btnLimpProd.Click += new System.EventHandler(this.btnLimpProd_Click_1);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(185)))), ((int)(((byte)(65)))));
            this.txtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProd.Location = new System.Drawing.Point(112, 67);
            this.txtNombreProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(158, 20);
            this.txtNombreProd.TabIndex = 2;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Location = new System.Drawing.Point(550, 70);
            this.btnAgregarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(68, 26);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(33, 418);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 43);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAdminProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(122)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(733, 473);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminProductos";
            this.Text = "Catalogo de productos";
            this.Load += new System.EventHandler(this.frmAdminProductos_Load);
            this.grpDatosCatalogo.ResumeLayout(false);
            this.grpDatosCatalogo.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAgregar.ResumeLayout(false);
            this.grpAgregar.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgregProd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCatalogo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblBuscar;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.ComboBox cboCategoria;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl tabListado;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpAgregar;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Label lblDescCat;
        private System.Windows.Forms.Label lblCatNombre;
        private System.Windows.Forms.TextBox txtNombreCateg;
        private System.Windows.Forms.Button btnLimpiarCat;
        private System.Windows.Forms.TextBox txtDescpCateg;
        private System.Windows.Forms.Button btnBuscarCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscCateg;
        private System.Windows.Forms.DataGridView dtgAgregProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Button btnLimpProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.TextBox txtDescripProd;
        private System.Windows.Forms.TextBox txtStockProd;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboCategProd;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Button btnVolver;
    }
}