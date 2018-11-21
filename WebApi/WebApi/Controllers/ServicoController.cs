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
    public class ServicoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Servico> Get()
        {
            var toReturn = new Servico().Get(DbConnection.GetInstance());

            return toReturn;
        }

        // GET api/<controller>/5
        public IEnumerable<Servico> Get(int id)
        {
            var toReturn = new Servico().Get(DbConnection.GetInstance(), id);

            return toReturn;
        }

        // POST api/<controller>
        public void Post([FromBody]Servico value)
        {
            value.Insert(DbConnection.GetInstance());
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Servico value)
        {
            value.Update(DbConnection.GetInstance(), id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var toDelete = new Servico().Delete(DbConnection.GetInstance(), id);
        }
    }
}