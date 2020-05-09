using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class HomeController : ApiController
    {
        public static List<string> sampleProducts = new List<string>()
        {
            "Chai",
            "Chang",
            "Ikura"

        };
        public IEnumerable<string> Get()
        {
            return sampleProducts;
        }
        public string Get(int id)
        {
            return sampleProducts[id];
        }
        public void Post([FromBody]string value)
        {
          sampleProducts.Add(value);
        }
        public void Put(int id,[FromBody]string value)
        {
            sampleProducts[id] = value;

        }
        public void Delete(int id)
        {
            sampleProducts.Remove(sampleProducts[id]);
        }
    }
}
