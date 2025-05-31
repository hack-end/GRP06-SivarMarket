using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivarMarket.BD
{
    internal class cn
    {
        private string conexionCadena = "Server=localhost\\SQLEXPRESS;Database=BD_SIVARMARKET;Trusted_Connection=True;";

        public SqlConnection Conexion()
        {
            SqlConnection conexion = new SqlConnection(conexionCadena);
            return conexion;
        }
    }
}