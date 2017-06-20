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
            PymesEntities db = new PymesEntities();
            return db.Articulos.Where(a => a.Activo == true);
        }
    }
}
