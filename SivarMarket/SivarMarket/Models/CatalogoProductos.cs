using System;
using System.Data;
using System.Drawing;
using System.Windows;
using SivarMarket.Models;
using SivarMarket.Services;
using System.Windows.Forms;

namespace SivarMarket.Forms.Products
{
    public class CatalogoProductos
    {
        private readonly frmAdminProductos _form;
        private readonly ProductoService _servicioProductos;
        private DataTable _datosProductos;

        public CatalogoProductos(frmAdminProductos form)
        {
            _form = form;
            _servicioProductos = new ProductoService();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            _form.dtgProductos.AutoGenerateColumns = false;
            _form.dtgProductos.ReadOnly = true; // No editable
            _form.dtgProductos.AllowUserToAddRows = false; // No permitir agregar filas
            _form.dtgProductos.AllowUserToDeleteRows = false; // No permitir eliminar filas
            _form.dtgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Limpiar columnas existentes
            _form.dtgProductos.Columns.Clear();

            // Configurar columnas manualmente
            _form.dtgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                DataPropertyName = "Codigo",
                HeaderText = "Código",
                Width = 100
            });

            _form.dtgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 200,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Configurar estilo para columnas numéricas
            var styleNumerico = new DataGridViewCellStyle
            {
                Format = "C2",
                Alignment = DataGridViewContentAlignment.MiddleRight
            };

            _form.dtgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Width = 80,
                DefaultCellStyle = styleNumerico
            });

            _form.dtgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
        }


        public void CargarProductos()
        {
            try
            {
                _datosProductos = _servicioProductos.ObtenerTodosProductos();
                _form.dtgProductos.DataSource = _datosProductos;

                CargarCategorias();
                //ActualizarBarraEstado($"Cargados {_datosProductos.Rows.Count} productos");
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar productos: {ex.Message}");
            }
        }

        private void CargarCategorias()
        {
            try
            {
                var categorias = _servicioProductos.ObtenerProductosConCategorias();
                _form.cboCategoria.DataSource = categorias;
                _form.cboCategoria.DisplayMember = "Nombre";
                _form.cboCategoria.ValueMember = "CategoriaID";
                _form.cboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar categorías: {ex.Message}");
            }
        }

        public void BuscarProductos()
        {
            try
            {
                string termino = _form.txtBuscar.Text.Trim();
                int? categoriaId = (int?)_form.cboCategoria.SelectedValue;

                DataView dv = _datosProductos.DefaultView;
                string filtro = "";

                if (!string.IsNullOrEmpty(termino))
                {
                    filtro += $"(Nombre LIKE '%{termino}%' OR Codigo LIKE '%{termino}%')";
                }

                if (categoriaId.HasValue)
                {
                    if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                    filtro += $"CategoriaID = {categoriaId.Value}";
                }

                dv.RowFilter = filtro;
                //ActualizarBarraEstado($"Mostrando {dv.Count} productos");
            }
            catch (Exception ex)
            {
                MostrarError($"Error al buscar productos: {ex.Message}");
            }
        }

        public void RefrescarProductos()
        {
            _form.txtBuscar.Clear();
            _form.cboCategoria.SelectedIndex = -1;
            CargarProductos();
        }

      //  private void ActualizarBarraEstado(string mensaje)
      //  {
      //      _form.LblEstado.Text = mensaje;
      //      _form.LblEstado.ForeColor = SystemColors.ControlText;
      //  }

        private void MostrarError(string mensaje)
        {
         //   _form.LblEstado.Text = mensaje;
        //    _form.LblEstado.ForeColor = Color.Red;
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Producto SeleccionarProducto()
        {
            if (_form.dtgProductos.SelectedRows.Count == 0)
            {
                MostrarError("Por favor seleccione un producto");
                return null;
            }

            try
            {
                int id = Convert.ToInt32(_form.dtgProductos.SelectedRows[0].Cells["colId"].Value);
                return _servicioProductos.ObtenerProductoPorId(id);
            }
            catch (Exception ex)
            {
                MostrarError($"Error al seleccionar producto: {ex.Message}");
                return null;
            }
        }
    }
}