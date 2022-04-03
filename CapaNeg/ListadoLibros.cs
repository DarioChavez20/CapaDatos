using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNeg
{
    public class ListadoLibros
    {
        public int id { get; set; }
        public string nombre_libro { get; set; }
        public int? cantidad { get; set; }
        public int? valor { get; set; }
        public System.DateTime? fecha_prestamo { get; set; }
        public int? fk_usuarios { get; set; }
    }
}
