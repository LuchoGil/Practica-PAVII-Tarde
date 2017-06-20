using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pymes.Data;

namespace PymesWeb.Controllers
{
    public class ClientesController : ApiController
    {
        public IHttpActionResult getClientes()
        {
            GestorClientes gestor = new GestorClientes();

            IQueryable<Cliente> lista = gestor.ObtenerTodos();

            return Ok(lista);
        }
    }
}
