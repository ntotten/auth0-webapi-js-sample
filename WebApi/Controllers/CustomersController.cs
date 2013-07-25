using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.ServiceModel.Security.Tokens;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/customers
        [Authorize]
        public IEnumerable<string> Get()
        {
            // you could access here the user_id by doing 
            // ClaimsPrincipal.Current.Claims.SingleOrDefault(c => c.Type == "sub").Value

            return new string[] { "John Doe", "Nancy Davolo" };
        }

        // GET api/customers/5
        public string Get(int n)
        {
            return "value";
        }

        // POST api/customers
        public void Post([FromBody]string value)
        {
        }

        // PUT api/customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/customers/5
        public void Delete(int id)
        {
        }
    }
}
