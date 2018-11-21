using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Connection;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChamadoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Chamado> Get()
        {
            var toReturn = new Chamado().Get(DbConnection.GetInstance());

            return toReturn;
        }

        // GET api/<controller>/5
        public IEnumerable<Chamado> Get(int id)
        {   
            var toReturn = new Chamado().Get(DbConnection.GetInstance(), id);

            return toReturn;
        }

        // POST api/<controller>
        public void Post([FromBody]Chamado value)
        {
            value.Insert(DbConnection.GetInstance());
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Chamado value)
        {
            value.Update(DbConnection.GetInstance(), id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var toDelete = new Chamado().Delete(DbConnection.GetInstance(), id);
        }
    }
}