using System.Linq;
using System.Web.Http;
using Pymes.Datos;

namespace Pymes.Controllers
{
    public class ArticulosController : ApiController
    {
        private GestorArticulos db = new GestorArticulos();

        // GET: api/Articulos
        public IQueryable<Articulo> GetArticulos()
        {
            return db.ObtenerTodos();
        }


    }
}