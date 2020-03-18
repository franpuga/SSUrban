using SSUrbanService.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SSUrbanService.Controllers
{
    public class InmuebleController : ApiController
    {
        [HttpPost]
        [Route("api/AddInmueble")]
        public void AddInmueble(InmuebleDTO inmueble)
        {

        }
    }
}