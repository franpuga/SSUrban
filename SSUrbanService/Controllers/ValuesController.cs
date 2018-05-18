using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SSUrbanModelo;

namespace SSUrbanService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IEnumerable<Inmuebles> Get(String expediente)
        {
            SSUrbanEntities ctx = new SSUrbanEntities();
            var estates = ctx.Inmuebles.Where(i => i.Expediente == expediente).ToList();
            ctx.Configuration.LazyLoadingEnabled = false; // Crear objetos DTO
            return estates;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
