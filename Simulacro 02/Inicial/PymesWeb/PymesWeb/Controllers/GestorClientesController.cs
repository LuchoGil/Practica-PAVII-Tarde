using Pymes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PymesWeb.Controllers
{
    public class GestorClientesController : ApiController
    {
        private GestorClientes gc = new GestorClientes();
        [HttpGet]
        public IQueryable<Cliente> Get()
        {
            return gc.ObtenerTodos();   
        }



    }
}
