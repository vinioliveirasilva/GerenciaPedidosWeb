using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Connection;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ComentarioController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Comentario> Get()
        {
            var toReturn = new Comentario().Get(DbConnection.GetInstance());

            return toReturn;
        }

        // GET api/<controller>/5
        public IEnumerable<Comentario> Get(int id)
        {
            var toReturn = new Comentario().Get(DbConnection.GetInstance(), id);

            return toReturn;
        }

        // POST api/<controller>
        public void Post([FromBody]Comentario value)
        {
            value.Insert(DbConnection.GetInstance());
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Comentario value)
        {
            value.Update(DbConnection.GetInstance(), id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var toDelete = new Comentario().Delete(DbConnection.GetInstance(), id);
        }
    }
}