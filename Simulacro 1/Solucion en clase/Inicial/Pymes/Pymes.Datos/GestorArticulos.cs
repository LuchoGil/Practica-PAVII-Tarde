using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pymes.Datos
{
    public class GestorArticulos
    {
        public IQueryable<Articulo> ObtenerTodos()
        {
            using(PymesEntities db = new PymesEntities())
            {
                return db.Articulos.Where(x => x.Activo == true);
            }
        }
    }
}
