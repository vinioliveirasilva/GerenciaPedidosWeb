using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Connection;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClienteController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Cliente> Get()
        {
            var toReturn = new Cliente().Get(DbConnection.GetInstance());

            return toReturn;
        }

        // GET api/<controller>/5
        public IEnumerable<Cliente> Get(int id)
        {
            var toReturn = new Cliente().Get(DbConnection.GetInstance(), id);

            return toReturn;
        }

        // POST api/<controller>
        public void Post([FromBody]Cliente value)
        {
            value.Insert(DbConnection.GetInstance());
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Cliente value)
        {
            value.Update(DbConnection.GetInstance(), id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var toDelete = new Cliente().Delete(DbConnection.GetInstance(), id);
        }
    }
}