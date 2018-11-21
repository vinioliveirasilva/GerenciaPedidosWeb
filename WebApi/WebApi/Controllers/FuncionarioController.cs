using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Connection;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FuncionarioController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Funcionario> Get()
        {
            var toReturn = new Funcionario().Get(DbConnection.GetInstance());

            return toReturn;
        }

        // GET api/<controller>/5
        public IEnumerable<Funcionario> Get(int id)
        {
            var toReturn = new Funcionario().Get(DbConnection.GetInstance(), id);

            return toReturn;
        }

        // POST api/<controller>
        public void Post([FromBody]Funcionario value)
        {
            value.Insert(DbConnection.GetInstance());
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Funcionario value)
        {
            value.Update(DbConnection.GetInstance(), id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var toDelete = new Funcionario().Delete(DbConnection.GetInstance(), id);
        }
    }
}