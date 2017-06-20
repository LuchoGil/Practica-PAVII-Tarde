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
        private GestorClientes db = new GestorClientes();
        [HttpGet]
        public IQueryable<Cliente> Get()
        {
            return db.ObtenerTodos();
        }
    }
}
