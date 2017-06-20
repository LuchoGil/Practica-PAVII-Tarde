using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pymes.Data
{
    public class GestorClientes
    {        

        public IQueryable<Cliente> ObtenerTodos()
        {
            PymesEntities db = new PymesEntities();
            return db.Clientes.Where(a => a.Localidad == "CORDOBA CAPITAL");
        }
    }
}
