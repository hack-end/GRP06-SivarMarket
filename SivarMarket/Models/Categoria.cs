using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SivarMarket.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
