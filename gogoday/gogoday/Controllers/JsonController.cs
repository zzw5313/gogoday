using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace gogoday.Controllers
{
    public class JsonController : ApiController
    {
        // GET api/json
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/json/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/json
        public void Post([FromBody]string value)
        {

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        // PUT api/json/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/json/5
        public void Delete(int id)
        {
        }
    }
}
