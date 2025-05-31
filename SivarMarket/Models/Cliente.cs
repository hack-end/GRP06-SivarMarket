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



        // Consulta de todos los clientes
        public DataTable consultarClientes(SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ConsultarClientes", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        //Consulta filtrada
        public DataTable consultarClientesFiltro(SqlConnection con, string busqueda)
        {
            using (SqlCommand cmd = new SqlCommand("SP_BuscarClienteFiltro", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Busqueda", busqueda);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Insertar cliente
        public void insertarCliente(SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SP_InsertarCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar cliente por ID
        public DataTable consultarPorID(SqlConnection con, int id)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ConsultarClientePorID", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Consultar cliente por ID para Venta
        public DataTable consultarPorID_Venta(SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ConsultarClientePorID_Venta", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Consultar clientes por nombre, apellido o ID
        public DataTable consultarClienteNombre_Apellido_ID(SqlConnection con, string dato)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ConsultarClienteNombre_Apellido_ID", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Busqueda", "%" + dato + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Consultar clientes para venta (solo ID, Nombre y Apellido)
        public DataTable consultarClientesFiltro(SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ConsultarClientesFiltro", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Actualizar cliente
        public void actualizarCliente(SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SP_ActualizarCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar cliente
        public void eliminarCliente(SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SP_EliminarCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
