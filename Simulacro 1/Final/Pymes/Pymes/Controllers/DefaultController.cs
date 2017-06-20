using Pymes.Datos;
using System.Linq;
using System.Web.Http;

namespace Pymes.Controllers
{
    public class DefaultController : ApiController
    {
        private GestorArticulos ga = new GestorArticulos();

        //GET: api/articulos

        public IQueryable<Articulo> GetArticulos()
        {
            return ga.ObtenerTodos();
        }
    }
}
