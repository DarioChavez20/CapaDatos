using System.Collections.Generic;
using System.Linq;

namespace CapaNeg
{
    public class Libros
    {
        public static List<ListadoLibros> Obtener()
        {
            using (CapaDatos.biblioteca_ZEntities datos = new CapaDatos.biblioteca_ZEntities())
            {
                return (from d in datos.libros
                        join u in datos.usuarios on d.fk_usuarios equals u.identificacion
                        select new ListadoLibros()
                        {
                            id = d.id,
                            nombre_libro = d.nombre_libro,
                            cantidad = d.cantidad,
                            valor = d.valor,
                            fecha_prestamo = d.fecha_prestamo,
                            fk_usuarios = d.fk_usuarios
                        }).ToList();
            }
        }
    }
}
