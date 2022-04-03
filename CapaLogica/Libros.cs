using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaLogica
{
   class Libros
    {
        public static List<CapaDatos.libros> Obtener() 
        {
            using (CapaDatos.biblioteca_ZEntities datos = new CapaDatos.biblioteca_ZEntities()) {
                return datos.libros.ToList(); 
            }
        }

    }
}
