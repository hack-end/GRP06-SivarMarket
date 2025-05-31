using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivarMarket.Models
{
    internal class Cliente
    {
        private int ClienteID;
        private string Nombre, Apellido, Telefono, Correo, Direccion;

        //Constructor con parametros
        public Cliente(int clienteID, string nombre, string apellido, string telefono, string correo, string direccion)
        {
            ClienteID = clienteID;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        //Constructor con parametros
        public Cliente(string nombre, string apellido, string telefono, string correo, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }
        //Constructor con clienteID como parametro
        public Cliente(int clienteID) 
        {
            ClienteID= clienteID;
        }

        //Constructor sin parametros
        public Cliente() { }


        //*** Consultas DML (consultar, insertar, actualizar) ***

        //Consulta de todos los clientes
        public DataTable consultarClientes(SqlConnection con)
        {
            
            string query = "SELECT * FROM MKTSV_Cliente";
            SqlDataAdapter datos = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            datos.Fill(dataTable);
            
            return dataTable;
        }

        //Agregar un nuevo cliente  la base de datos
        public void insertarCliente(SqlConnection con)
        {            
            string query = "INSERT INTO MKTSV_Cliente (Nombre, Apellido, Telefono, Correo, Direccion)"+
                            "VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Direccion)";

            using (SqlCommand comand = new SqlCommand(query, con))
            {
                comand.Parameters.AddWithValue("@Nombre", Nombre);
                comand.Parameters.AddWithValue("@Apellido", Apellido);
                comand.Parameters.AddWithValue("@Telefono", Telefono);
                comand.Parameters.AddWithValue("@Correo", Correo);
                comand.Parameters.AddWithValue("@Direccion", Direccion);

                comand.ExecuteNonQuery();              
            }
        }
        //Busqueda de un cliente por su ID se usa para cuando queremos actualizar los datos de un cliente
        public DataTable consultarPorID(SqlConnection con, int id)
        {
            string query = "SELECT * FROM MKTSV_Cliente WHERE ClienteID = @ClienteID";
            using (SqlCommand comand = new SqlCommand(query, con))
            {
                comand.Parameters.AddWithValue("@ClienteID", id);
                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable consultarClienteNombre_Apellido_ID(SqlConnection con, string dato)
        {
            string query = "SELECT ClienteID, Nombre, Apellido FROM MKTSV_Cliente WHERE" +
                " CAST(ClienteID AS NVARCHAR) LIKE @Busqueda" +
                " OR Nombre LIKE @Busqueda" +
                " OR Apellido LIKE @Busqueda";
            using (SqlCommand comand = new SqlCommand(query, con))
            {
                comand.Parameters.AddWithValue("@Busqueda", "%" + dato + "%");
                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Busqueda de clientes se usa para cuando vamos a realizar una venta ## Usado en frmSeleccionarCliente.cs ##
        public DataTable consultarClientesFiltro(SqlConnection con)
        {
            string query = "SELECT ClienteID, Nombre, Apellido FROM MKTSV_Cliente";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Busqueda de un cliente por su ID se usa para cuando vamos a realizar una venta ## Usado en frmVenta ##
        public DataTable consultarPorID_Venta(SqlConnection con)
        {
            string query = "SELECT ClienteID, CONCAT(Nombre, ' ' ,Apellido) AS Nombre_Completo, Telefono, Correo, Direccion FROM MKTSV_Cliente WHERE ClienteID = @ClienteID";
            using (SqlCommand comand = new SqlCommand(query, con))
            {
                comand.Parameters.AddWithValue("@ClienteID", ClienteID);
                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Actualiza los datos de un empleado de la base de datos
        public void actualizarCliente(SqlConnection con)
        {
            string query = "UPDATE MKTSV_Cliente SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, Correo=@Correo, Direccion=@Direccion WHERE ClienteID=@ClienteID";
            using (SqlCommand comand = new SqlCommand(query, con))
            {
                comand.Parameters.AddWithValue("@Nombre", Nombre);
                comand.Parameters.AddWithValue("@Apellido", Apellido);
                comand.Parameters.AddWithValue("@Telefono", Telefono);
                comand.Parameters.AddWithValue("@Correo", Correo);
                comand.Parameters.AddWithValue("@Direccion", Direccion);
                comand.Parameters.AddWithValue("@ClienteID", ClienteID);

                comand.ExecuteNonQuery();
            }
        }
    }
}
