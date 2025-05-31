using System;
using System.Data;
using System.Windows.Forms;
using SivarMarket.Models;
using SivarMarket.Services;

namespace SivarMarket.Forms.Products
{
    public partial class frmAdminProductos : Form
    {
        private int _categoriaSeleccionadaId = -1; 
        private int _productoSeleccionadoId = -1; 
        private readonly ProductoService _productoService = new ProductoService();

        public frmAdminProductos()
        {
            InitializeComponent();
            ConfigurarDataGridCategorias();
            ConfigurarDataGridViewProductos();
            CargarTablaCategorias();        // Precarga los datos en el DataGridView de categorías
            CargarCategorias();
            CargarProductos();
            CargarTablaProductos();
        }

        // Configura el DataGridView para mostrar los productos con sus categorías.
        private void ConfigurarDataGridViewCatalogProduct()
        {
            dtgProductos.AutoGenerateColumns = false;
            dtgProductos.Columns.Clear();

            dtgProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código",
                Width = 100
            });

            dtgProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Producto",
                HeaderText = "Nombre",
                Width = 200
            });

            dtgProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoría",
                Width = 150
            });

            dtgProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            // Botón Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
            {
                Name = "btnEditar",
                HeaderText = "",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 70
            };
            dtgCategorias.Columns.Add(btnEditar);

            // Botón Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dtgCategorias.Columns.Add(btnEliminar);

        }


        
        ///  Configura el DataGridView para mostrar los productos agregados.
        private void ConfigurarDataGridViewProductos()
        {
            dtgAgregProd.AutoGenerateColumns = false;
            dtgAgregProd.AllowUserToAddRows = false; // ← Esta línea elimina la fila vacía al final
            dtgAgregProd.Columns.Clear();

            // Botón Editar (primera columna)
            dtgAgregProd.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "btnEditar",
                HeaderText = "",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 70
            });

            // Botón Eliminar (segunda columna)
            dtgAgregProd.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "btnEliminar",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            // ID oculto
            dtgAgregProd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductoID",
                HeaderText = "ID",
                Name = "ProductoID",
                Visible = false
            });

            dtgAgregProd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código",
                Width = 100
            });

            dtgAgregProd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Producto",
                HeaderText = "Nombre",
                Width = 200
            });

            dtgAgregProd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoría",
                Width = 150
            });

            dtgAgregProd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dtgAgregProd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
        }

        private void ConfigurarDataGridCategorias()
        {
            dtgCategorias.AutoGenerateColumns = false;
            dtgCategorias.Columns.Clear();

            dtgCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                DataPropertyName = "CategoriaID",
                HeaderText = "ID",
                Width = 50
            });

            dtgCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150
            });

            dtgCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                Width = 200
            });


            dtgCategorias.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnEditar",
                HeaderText = "",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 70
            });


            dtgCategorias.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 70
            });

            dtgCategorias.ReadOnly = true;
            dtgCategorias.AllowUserToAddRows = false;
            dtgCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            string texto = txtbuscCateg.Text.Trim();
            var categorias = _categoriaService.BuscarCategorias(texto);
            dtgCategorias.DataSource = categorias;
        }


        private void CargarProductos()
        {
            try
            {
                dtgProductos.DataSource = _productoService.ObtenerProductosConCategorias();
                dtgAgregProd.DataSource = _productoService.ObtenerProductosConCategorias();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarTablaCategorias()
        {
            try
            {
                DataTable categorias = _productoService.ObtenerCategorias(); // o BuscarCategorias("") si tienes filtro
                dtgCategorias.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías en la tabla: " + ex.Message);
            }
        }

        private void CargarTablaProductos()
        {
            try
            {
                DataTable productos = _productoService.ObtenerProductosConCategorias();
                dtgProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la tabla de productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = _productoService.ObtenerCategorias();

                // Se encarga de cargar los combobox de categorías en el formulario principal
                cboCategoria.DataSource = categorias;
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "CategoriaID";
                cboCategoria.SelectedIndex = -1;

                // Se encarga de carga los combobox de categorías en el formulario de agregar producto
                cboCategProd.DataSource = categorias.Copy(); 
                cboCategProd.DisplayMember = "Nombre";
                cboCategProd.ValueMember = "CategoriaID";
                cboCategProd.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            try
            {
                string textoBusqueda = txtBuscar.Text.Trim();
                int categoriaIdSeleccionada = cboCategoria.SelectedIndex != -1 ? Convert.ToInt32(cboCategoria.SelectedValue) : -1;

                DataTable productos = _productoService.ObtenerProductosConCategorias();
                DataView dv = productos.DefaultView;

                string filtro = "";

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    filtro = $"Producto LIKE '%{textoBusqueda}%' OR Codigo LIKE '%{textoBusqueda}%'";
                }

                if (categoriaIdSeleccionada != -1)
                {
                    if (!string.IsNullOrEmpty(filtro))
                        filtro += " AND ";

                    filtro += $"CategoriaID = {categoriaIdSeleccionada}";
                }

                dv.RowFilter = filtro;
                dtgProductos.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private readonly CategoriaService _categoriaService = new CategoriaService();
        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCateg.Text.Trim();
            string descripcion = txtDescpCateg.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.");
                return;
            }

            bool exito = false;

            if (_categoriaSeleccionadaId == -1)
            {
           
                exito = _categoriaService.AgregarCategoria(nombre, descripcion);
                if (exito)
                    MessageBox.Show("Categoría agregada correctamente.");
            }
            else
            {
                
                exito = _categoriaService.ActualizarCategoria(_categoriaSeleccionadaId, nombre, descripcion);
                if (exito)
                    MessageBox.Show("Categoría actualizada correctamente.");

             
                _categoriaSeleccionadaId = -1;
                btnAgregarCat.Text = "Agregar Categoría"; 
            }

            if (exito)
            {
                LimpiarCamposCategoria();
                CargarTablaCategorias();
                CargarCategorias();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar la categoría.");
            }
        }


        private void dtgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            string nombreColumna = dtgCategorias.Columns[e.ColumnIndex].Name;

   
            int categoriaId = Convert.ToInt32(dtgCategorias.Rows[e.RowIndex].Cells["colID"].Value);

            if (nombreColumna == "btnEditar")
            {
             
                txtNombreCateg.Text = dtgCategorias.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                var descripcionValue = dtgCategorias.Rows[e.RowIndex].Cells["colDescripcion"].Value;
                txtDescpCateg.Text = descripcionValue != null ? descripcionValue.ToString() : string.Empty;

            
                _categoriaSeleccionadaId = categoriaId; 

                btnAgregarCat.Text = "Actualizar"; 
            }
            else if (nombreColumna == "btnEliminar")
            {
                var confirmacion = MessageBox.Show("¿Estás seguro de eliminar esta categoría?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = _productoService.EliminarCategoria(categoriaId);
                    if (eliminado)
                    {
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTablaCategorias();
                        CargarCategorias(); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAgregarProd_Click_1(object sender, EventArgs e)
        {
            string codigo = txtCodProd.Text.Trim();
            string nombre = txtNombreProd.Text.Trim();
            string descripcion = txtDescripProd.Text.Trim();
            int stock = int.TryParse(txtStockProd.Text, out var s) ? s : 0;
            int categoriaId = cboCategProd.SelectedIndex != -1 ? Convert.ToInt32(cboCategProd.SelectedValue) : -1;

            if (!decimal.TryParse(txtPrecioProd.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Por favor, ingresa un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Código y nombre son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoriaId == -1)
            {
                MessageBox.Show("Selecciona una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_productoSeleccionadoId == -1)
            {
                // Insertar
                bool exito = _productoService.AgregarProducto(codigo, nombre, descripcion, precio, stock, categoriaId);
                if (exito)
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    CargarProductos();
                    LimpiarCamposProducto();
                }
            }
            else
            {
                // Actualizar
                Producto p = new Producto
                {
                    ProductoID = _productoSeleccionadoId,
                    Codigo = codigo,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = precio,
                    Stock = stock,
                    CategoriaID = categoriaId
                };

                bool exito = _productoService.ActualizarProducto(p);
                if (exito)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    CargarProductos();
                    LimpiarCamposProducto();
                    btnAgregarProd.Text = "Agregar Producto";
                    _productoSeleccionadoId = -1;
                }
            }
        }



       
     

       

       
        private void dtgAgregProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string nombreColumna = dtgAgregProd.Columns[e.ColumnIndex].Name;

            int productoId = Convert.ToInt32(dtgAgregProd.Rows[e.RowIndex].Cells["ProductoID"].Value);

            if (nombreColumna == "btnEditar")
            {
                // Obtiene los datos del producto seleccionado
                Producto producto = _productoService.ObtenerProductoPorId(productoId);
                if (producto != null)
                {
                    txtCodProd.Text = producto.Codigo;
                    txtNombreProd.Text = producto.Nombre;
                    txtDescripProd.Text = producto.Descripcion;
                    txtStockProd.Text = producto.Stock.ToString();
                    txtPrecioProd.Text = producto.Precio.ToString();
                    cboCategProd.SelectedValue = producto.CategoriaID;

                    // Guardar ID para actualizar
                    _productoSeleccionadoId = producto.ProductoID;

                    btnAgregarProd.Text = "Actualizar Producto";
                }
            }
            else if (nombreColumna == "btnEliminar")
            {
                var confirmacion = MessageBox.Show("¿Deseas eliminar este producto?", "Confirmación",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = _productoService.EliminarProducto(productoId);
                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        CargarProductos(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.");
                    }
                }
            }
        }



        private void btnLimpProd_Click_1(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
            CargarProductos();
        }

        private void btnLimpiarCat_Click(object sender, EventArgs e)
        {
            txtNombreCateg.Text = "";
            txtDescpCateg.Text = "";
            LimpiarCamposCategoria();
        }


        private void LimpiarCamposProducto()
        {
            txtCodProd.Text = "";
            txtNombreProd.Text = "";
            txtDescripProd.Text = "";
            txtPrecioProd.Text = "";
            txtStockProd.Text = "";
            cboCategProd.SelectedIndex = -1;

            // Restaurar el estado del botón
            btnAgregarProd.Text = "Agregar Producto";
            _productoSeleccionadoId = -1;
        }

        private void LimpiarCamposCategoria()
        {
            txtNombreCateg.Text = "";
            txtDescpCateg.Text = "";
            _categoriaSeleccionadaId = -1;
            btnAgregarCat.Text = "Agregar Categoría";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            cboCategoria.SelectedIndex = -1;
            CargarProductos();
        }

    }
}

