using Practice_NTT_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Practice_NTT_Framework.Controllers.API
{
    public class CompanyController : ApiController
    {
        DataContext dataContext = new DataContext();
        // GET: api/Company
        public IHttpActionResult Get()
        {
            List<Company> ListEmployees = dataContext.Companys.ToList();
            return Ok(new { ListEmployees });
        }

        // GET: api/Company/5
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok();
        }

        // POST: api/Company
        public async Task<IHttpActionResult> Post([FromBody]string value)
        {
            return Ok();
        }

        // PUT: api/Company/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE: api/Company/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
