using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pymes.Datos;

namespace Pymes.Controllers
{
    public class ArticulosController : ApiController
    {
        public IHttpActionResult Get()
        {
            GestorArticulos gestor = new GestorArticulos();

            IQueryable<Articulo> list = gestor.ObtenerTodos();

            return Ok(list);
        }
    }
}
