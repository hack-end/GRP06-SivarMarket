using SivarMarket.BD;
using SivarMarket.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SivarMarket
{
    public partial class frmVenta : Form
    {
        Cliente cliente;
        cn conexion = new cn();
        Producto producto;

        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //creamos un objeto de tipo frmSeleccionarCliente que es el form que muestra los clientes que tenemos y el boton para seleccionar a un cliente
                frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

                //Luego de haber creado el objeto lo mostramos como una ventana modal, si selecciona cliente entra al if sino solo cierra la ventana
                if (frmSeleccionarCliente.ShowDialog() == DialogResult.OK)
                {
                    //Aqui ya tenemos el id del cliente
                    int idCliente = Convert.ToInt32(frmSeleccionarCliente.ClienteSeleccionado);
                    //Instanciamos el objeto de Cliente le pasamos el idCliente haciendo uso de uno de los constructores creados en la clase CLiente
                    cliente = new Cliente(idCliente);
                    //Le pasamos la conexion a sqlserver
                    using (SqlConnection con = conexion.Conexion())
                    {
                        //Abrimos la conexion a la base de datos
                        con.Open();
                        //Lo que haremos sera cargar los datos del cliente en nuestro datagridview
                        dtgCliente.DataSource = cliente.consultarPorID_Venta(con);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cargarDatos();
            //Permitimos que la celda de Cantidad si se pueda modificar o escribir dentro
            dtgProductos.Columns["Cantidad"].ReadOnly = false;
        }

        private void cargarDatos()
        {
            //Cargar datos de productos codigo, producto(nombre), categoria, precio, stock
            using (SqlConnection con = conexion.Conexion())
            {
                con.Open();
                producto = new Producto();
                dtgProductos.DataSource = producto.consultarProductos(con);
            }
        }

        private void dtgProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Esta funcion la usamos nada mas para asegurarnos de que la cantidad que se escriba a la hora de agregar productos al carrito sea un numero
            if (dtgProductos.CurrentCell.ColumnIndex == dtgProductos.Columns["Cantidad"].Index)
            {
                TextBox txtEdit = e.Control as TextBox;
                if (txtEdit != null) 
                {
                    txtEdit.KeyPress -= soloNumeros_KeyPress;
                    txtEdit.KeyPress += soloNumeros_KeyPress;
                }
            }
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            //Esta funcion la usamos para cuando se escribe algo en el buscador de productos

            //Si esta vacio el txtBuscarProducto entra al if y carga todos los productos
            //Si ya esta algo escrito entra al else y busca el producto dependiendo lo escrito 
            if (txtBuscarProducto.Text.ToString().Trim() == string.Empty)
            {
                cargarDatos();
            }
            else
            {
                using (SqlConnection con = conexion.Conexion())
                {
                    con.Open();
                    producto = new Producto();
                    dtgProductos.DataSource = producto.consultarProductoFiltrado(con, txtBuscarProducto.Text.ToString());
                }
            }
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esta funcion se asegura de que se de clic al boton de agregar en el datagridView de Productos
            //Se asegura que se le de clic a la columna del boton, y que el clic sea en un dato no en la primera fila donde estan los nombres de las columnas
            if (e.ColumnIndex == dtgProductos.Columns["Accion"].Index && e.RowIndex >= 0)
            {
                // guardamos dtgProductos.Rows[e.RowIndex] en fila para evitar escribir tanto texto
                var fila = dtgProductos.Rows[e.RowIndex];
                // guardamos la cantidad que se agregara de x producto al carrito
                // value? significa que si el campo de cantidad esta vacio guarda null en cantidadTexto, usando para validar que se escriba una cantidad en ese campo
                string cantidadTexto = fila.Cells["Cantidad"].Value?.ToString();

                //Validando que el campo no vaya con un valor incorrecto como espacio en blanco o  valores negativos
                if (string.IsNullOrWhiteSpace(cantidadTexto) || !int.TryParse(cantidadTexto, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad valida mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtgProductos.CurrentCell = fila.Cells["Cantidad"];
                    dtgProductos.BeginEdit(true);

                    return;
                }

                //Si el codigo llega aca significa que el campo de cantidad tiene un numero valido
                //Guardamos los datos necesarios para las operaciones y pasarlo al carrito
                string codigo = fila.Cells["Codigo"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string precio = fila.Cells["Precio"].Value.ToString();
                decimal subtotal = Convert.ToDecimal(precio) * Convert.ToInt32(cantidadTexto);


                //Variable que tiene la cantidad de producto que tenemos realmente en stock
                int stock = Convert.ToInt32(fila.Cells["Stock"].Value.ToString());

                // Ahora validamos que lo que el cliente quiere comprar no supere lo que tenemos disponible en stock en dado caso lo supera muestra un mensaje de error
                if (Convert.ToInt32(cantidadTexto) > stock)
                {
                    //Mensaje de error por si la compra supera la cantidad en stock
                    errorStock();
                    return;
                }

                //Agregamos la cantidad a comprar

                //esta variable la ocupamos para saber si un producto que se esta agregando al carrito ya esta en el carrito
                bool encontrado = false;

                //Usamos un foreach para recorrer cada fila del carrito
                foreach (DataGridViewRow filaCarrito in dtgCarrito.Rows)
                {
                    //Este if comprueba si el nuevo producto que se esta agregando ya estaba anteriormente en el carrito
                    //Si ya estaba agregado el producto no debemos agregar una nueva fila nada mas cambiar la cantidad de producto y su SubTotal
                    if (filaCarrito.Cells["CodigoCarrito"].Value.ToString() == codigo)
                    {
                        //Ademas guardamos la cantidad total del producto que se esta agregando con la cantidad que ya estaba previamente en el carrito
                        int cantidadTotal = Convert.ToInt32(filaCarrito.Cells["CantidadCarrito"].Value.ToString()) + Convert.ToInt32(cantidadTexto);
                        //Validar que lo que se compra no supere lo de stock tanto al momento de agregar la primera vez como al añadir más al carrito
                        //Si en dado caso la cantidad nueva del producto mas la cantidad del carrito del mismo producto supera la cantidad en stock mostramos el mensaje de error
                        if (cantidadTotal > stock)
                        {
                            //Mensaje de error por si supera stock
                            errorStock();
                            fila.Cells["Cantidad"].Value = "";
                            return;
                        }

                        //Actualizamos nada mas cantidad y total a pagar en vez de agregar una nueva fila
                        int nuevaCantidad = Convert.ToInt32(filaCarrito.Cells["CantidadCarrito"].Value.ToString()) + Convert.ToInt32(cantidadTexto);
                        decimal nuevoTotal = nuevaCantidad * Convert.ToDecimal(precio);
                        //Actualizando las filas
                        filaCarrito.Cells["CantidadCarrito"].Value = nuevaCantidad;
                        filaCarrito.Cells["SubTotalCarrito"].Value = nuevoTotal.ToString("0.00");
                        encontrado = true;

                        TotalPagar();
                    }
                }
                //En dado caso no se encontro el producto en el carrito solo debemos agregar una nueva fila
                if (encontrado == false) 
                {
                    dtgCarrito.Rows.Add(codigo, nombre, precio, cantidadTexto, subtotal.ToString("0.00"));
                    TotalPagar();
                }                

                fila.Cells["Cantidad"].Value = "";
            }
        }

        private void errorStock()
        {
            MessageBox.Show("La cantidad que se comprara supera la cantidad que hay en stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nos aseguramos de que la fila a la que se le da clic no sea el encabezado de la tabla
            if (e.RowIndex >= 0)
            {
                //Este if es para saber si se dio clicl al boton de quitar todo de carrito, si eso es asi dentra al if
                if (dtgCarrito.Columns[e.ColumnIndex].Name=="QuitarTCarrito")
                {
                    //Muestra un mensaje el cual mostrara el mensaje y si se da clic al boton de si elimina a ese producto del carrio,
                    //quita toda la cantidad de ese producto y borra la fila
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea quitar este producto del carrito?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        dtgCarrito.Rows.RemoveAt(e.RowIndex);
                        TotalPagar();
                    }
                }

                //Si se da clic al boton de quitar, ese nada mas quita cierta cantidad de producto del carrito
                if (dtgCarrito.Columns[e.ColumnIndex].Name == "QuitarCarrito")
                {
                    //Guardamos la cantidad a quitar del carrito
                    string cantidadQuitar = dtgCarrito.Rows[e.RowIndex].Cells["Quitar_S"].Value?.ToString();

                    //En dado caso el campo cantidad esta vacio mostramos un mensaje de error sino hay error entra a else
                    if (string.IsNullOrWhiteSpace(cantidadQuitar))
                    {
                        MessageBox.Show("Asegurese de no dejar vacio el campo o con valores incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Guardamos la cantidad de x producto que hay en el carrito
                        int cantidadCarrito = Convert.ToInt32(dtgCarrito.Rows[e.RowIndex].Cells["CantidadCarrito"].Value.ToString());

                        //Nos aseguramos de que la cantidad a quitar no supere la que hay en el carrito, si es asi muestra error sino entra a else
                        if (Convert.ToInt32(cantidadQuitar) > cantidadCarrito)
                        {
                            MessageBox.Show("No puede quitar mas de la cantidad que esta en el carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Mostramos un mensaje con la cantidad a quitar y el nombre del prodcuto, si la respuesta es si quita x cantidad de cierto producto
                            string producto = dtgCarrito.Rows[e.RowIndex].Cells["NombreCarrito"].Value.ToString();
                            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea quitar '" + cantidadQuitar + "' del producto '" + producto + "' del carrito?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                int resta = Convert.ToInt32(cantidadCarrito) - Convert.ToInt32(cantidadQuitar);
                                //En dado caso la cantidad a quitar es la misma que la cantidad en carrito eliminamos la fila sino es asi entra a else
                                if (resta==0)
                                {
                                    dtgCarrito.Rows.RemoveAt(e.RowIndex);
                                }
                                else
                                {
                                    //Asignamos la nueva cantidad luego de haber quitado los productos
                                    dtgCarrito.Rows[e.RowIndex].Cells["CantidadCarrito"].Value = resta.ToString();
                                    //Actualizamos el total a pagar del producto (precio*resta)
                                    decimal precio = Convert.ToDecimal(dtgCarrito.Rows[e.RowIndex].Cells["PrecioCarrito"].Value.ToString());
                                    decimal subtotal = resta * precio;
                                    dtgCarrito.Rows[e.RowIndex].Cells["SubTotalCarrito"].Value = subtotal.ToString("0.00");
                                    dtgCarrito.Rows[e.RowIndex].Cells["Quitar_S"].Value = "";
                                }
                                TotalPagar();
                                
                            }
                        }                        
                    }                    
                }
            }
        }

        private void dtgCarrito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Nos aseguramos que lo que se escriba en cantidad a quitar sean numeros nada mas
            if (dtgCarrito.CurrentCell.ColumnIndex == dtgCarrito.Columns["Quitar_S"].Index)
            {
                TextBox txtEdit = e.Control as TextBox;
                if (txtEdit != null)
                {
                    txtEdit.KeyPress -= soloNumeros_KeyPress;
                    txtEdit.KeyPress += soloNumeros_KeyPress;
                }
            }
        }

        //Lo usamos para poner el precio en label de total a pagar
        private void TotalPagar()
        {
            if (dtgCarrito.Rows.Count == 0)
            {
                lblTotalPagar.Text = "Total a pagar: $ ";
            }
            else
            {
                decimal totalPagar = 0;
                //Solo necesitamos recorrer el datagridviewcarrito despues de cada operacion, es decir despues de agregar al carrito o quitar del carrito
                foreach (DataGridViewRow fila in dtgCarrito.Rows)
                {
                    totalPagar += Convert.ToDecimal(fila.Cells["SubTotalCarrito"].Value.ToString());
                }
                lblTotalPagar.Text = "Total a pagar: $ " + totalPagar.ToString("0.00");
            }
                
        }

        // botones funcionalidad
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dtgCliente.Rows.Count != 0)
            {
                if (dtgCarrito.Rows.Count == 0)
                {
                    MessageBox.Show("Asegurese de agregar productos al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //si llego hasta aca significa que ya se selecciono un cliente, y se agregaron productos al carrito
                    //Lo que nos queda es recorrer el datagridview para recuperar los datos que nos interesan ingresar a venta y detalleventa

                    producto = new Producto();
                    using (SqlConnection con = conexion.Conexion())
                    {
                        con.Open();
                        //Valores que tenemos desde antes de hacer el foreach
                        int clienteID = Convert.ToInt32(dtgCliente.Rows[0].Cells["ClienteID"].Value.ToString());
                        int UsuarioiD = SesionUsuario.UsuarioId;
                        string metodoPago;
                        if (radTarjeta.Checked==true) 
                        {
                            metodoPago = "Tarjeta";
                        }else if (radEfectivo.Checked==true)
                        {
                            metodoPago = "Efectivo";
                        }
                        else
                        {
                            metodoPago = "Ambos";
                        }

                        DateTime fechaVenta = DateTime.Now;
                        decimal impuesto = 0.00m;
                        //Primer foreach para recorrer el dtgCarrito y obtener nada mas el total a pagar
                        decimal totalPagar = 0;
                        //Solo necesitamos recorrer el datagridviewcarrito despues de cada operacion, es decir despues de agregar al carrito o quitar del carrito
                        foreach (DataGridViewRow filaSubtotal in dtgCarrito.Rows)
                        {
                            totalPagar += Convert.ToDecimal(filaSubtotal.Cells["SubTotalCarrito"].Value.ToString());
                        }

                        //Aca ya tenemos lo necesario para insertar los datos en venta
                        Venta nuevaVenta = new Venta(clienteID, UsuarioiD, fechaVenta, totalPagar, impuesto, metodoPago);
                        //El VentaID que usaremos para detalle venta ahora esta en el objeto nada mas debemos recuperarlo
                        
                        nuevaVenta.insertarVenta(con);


                        //Preparamos lo necesario para insertar datos en detalleventa
                        int ventaid = nuevaVenta.devolverVentaID();
                        //Segundo foreach para recorrer cada fila de dtgCarrito e inertar datos en DetalleVenta
                        
                        foreach (DataGridViewRow filaCarrito in dtgCarrito.Rows)
                        {
                            //Recuperamos los datos que necesitamos lo hacemos por cada fila y consultamos el ID del producto usando su codigo
                            string codigo = filaCarrito.Cells["CodigoCarrito"].Value.ToString();
                            int productoid = producto.obtenerProductoID(con, codigo);
                            int cantidad = Convert.ToInt32(filaCarrito.Cells["CantidadCarrito"].Value.ToString());
                            decimal precio = Convert.ToDecimal(filaCarrito.Cells["PrecioCarrito"].Value.ToString());
                            decimal subtotal = Convert.ToDecimal(filaCarrito.Cells["SubTotalCarrito"].Value.ToString());

                            DetalleVenta detalleVenta = new DetalleVenta(ventaid,productoid, cantidad, precio, subtotal);
                            detalleVenta.insertarDetalleVenta(con);

                        }
                        //Preguntar si desea ver el detalle de la venta con nombre de cliente y vendedor total pagado
                        DialogResult resultado = MessageBox.Show("Desea ver el detalle de la venta", "Detalles", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            frmDetallePago frmDetallePago = new frmDetallePago(ventaid);
                            frmDetallePago.ShowDialog();
                        }
                        //Recargamos los datos a la tabla de productos, limpiamos las tablas de cliente y carrito
                        cargarDatos();
                        limpiarDatos();
                        radTarjeta.Checked = true;
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            dtgCarrito.Rows.Clear();
            lblTotalPagar.Text = "Total a pagar: $ ";
            DataTable dt = (DataTable)dtgCliente.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
        }
    }
}