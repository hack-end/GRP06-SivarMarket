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
            this.grpDatosCatalogo.Location = new System.Drawing.Point(53, 19);
            this.grpDatosCatalogo.Name = "grpDatosCatalogo";
            this.grpDatosCatalogo.Size = new System.Drawing.Size(781, 217);
            this.grpDatosCatalogo.TabIndex = 0;
            this.grpDatosCatalogo.TabStop = false;
            this.grpDatosCatalogo.Text = "Datos de busqueda";
            this.grpDatosCatalogo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(378, 68);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(66, 68);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 16);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(410, 133);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 39);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(235, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(464, 65);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(151, 24);
            this.cboCategoria.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(149, 62);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(151, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // tabListado
            // 
            this.tabListado.AccessibleDescription = "";
            this.tabListado.AccessibleName = "";
            this.tabListado.Controls.Add(this.tabPage1);
            this.tabListado.Controls.Add(this.tabPage2);
            this.tabListado.Controls.Add(this.tabPage3);
            this.tabListado.Location = new System.Drawing.Point(39, 29);
            this.tabListado.Name = "tabListado";
            this.tabListado.SelectedIndex = 0;
            this.tabListado.Size = new System.Drawing.Size(899, 479);
            this.tabListado.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgProductos);
            this.tabPage1.Controls.Add(this.grpDatosCatalogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgProductos
            // 
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
            this.dtgProductos.Location = new System.Drawing.Point(58, 257);
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
            this.dtgProductos.Size = new System.Drawing.Size(779, 180);
            this.dtgProductos.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgCategorias);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.grpAgregar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgCategorias
            // 
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
            this.dtgCategorias.Location = new System.Drawing.Point(17, 219);
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
            this.dtgCategorias.Size = new System.Drawing.Size(867, 209);
            this.dtgCategorias.TabIndex = 2;
            this.dtgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbuscCateg);
            this.groupBox1.Location = new System.Drawing.Point(466, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.Location = new System.Drawing.Point(152, 112);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(91, 32);
            this.btnBuscarCat.TabIndex = 7;
            this.btnBuscarCat.Text = "Buscar";
            this.btnBuscarCat.UseVisualStyleBackColor = true;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // txtbuscCateg
            // 
            this.txtbuscCateg.Location = new System.Drawing.Point(113, 58);
            this.txtbuscCateg.Name = "txtbuscCateg";
            this.txtbuscCateg.Size = new System.Drawing.Size(190, 22);
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
            this.grpAgregar.Location = new System.Drawing.Point(15, 21);
            this.grpAgregar.Name = "grpAgregar";
            this.grpAgregar.Size = new System.Drawing.Size(429, 181);
            this.grpAgregar.TabIndex = 0;
            this.grpAgregar.TabStop = false;
            this.grpAgregar.Text = "Agregar";
            // 
            // lblDescCat
            // 
            this.lblDescCat.AutoSize = true;
            this.lblDescCat.Location = new System.Drawing.Point(17, 85);
            this.lblDescCat.Name = "lblDescCat";
            this.lblDescCat.Size = new System.Drawing.Size(79, 16);
            this.lblDescCat.TabIndex = 6;
            this.lblDescCat.Text = "Descripcion";
            // 
            // lblCatNombre
            // 
            this.lblCatNombre.AutoSize = true;
            this.lblCatNombre.Location = new System.Drawing.Point(17, 45);
            this.lblCatNombre.Name = "lblCatNombre";
            this.lblCatNombre.Size = new System.Drawing.Size(56, 16);
            this.lblCatNombre.TabIndex = 5;
            this.lblCatNombre.Text = "Nombre";
            // 
            // txtNombreCateg
            // 
            this.txtNombreCateg.Location = new System.Drawing.Point(113, 42);
            this.txtNombreCateg.Name = "txtNombreCateg";
            this.txtNombreCateg.Size = new System.Drawing.Size(210, 22);
            this.txtNombreCateg.TabIndex = 4;
            // 
            // btnLimpiarCat
            // 
            this.btnLimpiarCat.Location = new System.Drawing.Point(219, 127);
            this.btnLimpiarCat.Name = "btnLimpiarCat";
            this.btnLimpiarCat.Size = new System.Drawing.Size(91, 32);
            this.btnLimpiarCat.TabIndex = 3;
            this.btnLimpiarCat.Text = "Limpiar";
            this.btnLimpiarCat.UseVisualStyleBackColor = true;
            this.btnLimpiarCat.Click += new System.EventHandler(this.btnLimpiarCat_Click);
            // 
            // txtDescpCateg
            // 
            this.txtDescpCateg.Location = new System.Drawing.Point(113, 79);
            this.txtDescpCateg.Name = "txtDescpCateg";
            this.txtDescpCateg.Size = new System.Drawing.Size(210, 22);
            this.txtDescpCateg.TabIndex = 2;
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(100, 127);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(91, 32);
            this.btnAgregarCat.TabIndex = 0;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgAgregProd);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(891, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgAgregProd
            // 
            this.dtgAgregProd.AllowUserToAddRows = false;
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
            this.dtgAgregProd.Location = new System.Drawing.Point(12, 220);
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
            this.dtgAgregProd.Size = new System.Drawing.Size(867, 209);
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
            this.groupBox3.Location = new System.Drawing.Point(10, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 181);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(488, 85);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(193, 22);
            this.txtPrecioProd.TabIndex = 15;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(414, 85);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // cboCategProd
            // 
            this.cboCategProd.FormattingEnabled = true;
            this.cboCategProd.Location = new System.Drawing.Point(488, 34);
            this.cboCategProd.Name = "cboCategProd";
            this.cboCategProd.Size = new System.Drawing.Size(193, 24);
            this.cboCategProd.TabIndex = 13;
            // 
            // txtStockProd
            // 
            this.txtStockProd.Location = new System.Drawing.Point(488, 129);
            this.txtStockProd.Name = "txtStockProd";
            this.txtStockProd.Size = new System.Drawing.Size(193, 22);
            this.txtStockProd.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(414, 132);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Location = new System.Drawing.Point(414, 40);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(66, 16);
            this.lblPrecioProd.TabIndex = 10;
            this.lblPrecioProd.Text = "Categoria";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(17, 129);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(79, 16);
            this.lblDescProd.TabIndex = 8;
            this.lblDescProd.Text = "Descripcion";
            // 
            // txtDescripProd
            // 
            this.txtDescripProd.Location = new System.Drawing.Point(150, 123);
            this.txtDescripProd.Name = "txtDescripProd";
            this.txtDescripProd.Size = new System.Drawing.Size(210, 22);
            this.txtDescripProd.TabIndex = 7;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(17, 85);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(56, 16);
            this.lblNombreProd.TabIndex = 6;
            this.lblNombreProd.Text = "Nombre";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(17, 45);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(127, 16);
            this.lblCodProd.TabIndex = 5;
            this.lblCodProd.Text = "Codigo de Producto";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(150, 39);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(210, 22);
            this.txtCodProd.TabIndex = 4;
            // 
            // btnLimpProd
            // 
            this.btnLimpProd.Location = new System.Drawing.Point(733, 34);
            this.btnLimpProd.Name = "btnLimpProd";
            this.btnLimpProd.Size = new System.Drawing.Size(91, 32);
            this.btnLimpProd.TabIndex = 3;
            this.btnLimpProd.Text = "Limpiar";
            this.btnLimpProd.UseVisualStyleBackColor = true;
            this.btnLimpProd.Click += new System.EventHandler(this.btnLimpProd_Click_1);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(150, 82);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(210, 22);
            this.txtNombreProd.TabIndex = 2;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(733, 86);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(91, 32);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click_1);
            // 
            // frmCatalogoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 530);
            this.Controls.Add(this.tabListado);
            this.Name = "frmCatalogoProductos";
            this.Text = "Catalogo de productos";
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
    }
}