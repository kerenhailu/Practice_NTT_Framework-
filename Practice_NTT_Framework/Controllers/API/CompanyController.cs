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
            List<Company> ListCompanys = dataContext.Companys.ToList();
            return Ok(new { ListCompanys });
        }

        // GET: api/Company/5
        public async Task<IHttpActionResult> Get(int id)
        {

            try
            {
                Company company = await dataContext.Companys.FindAsync(id);

                //הישן
                //Companys company  = dataContext.Companys.First((itemID) => itemID.Id == id);
                return Ok(new { company });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Company
        public async Task<IHttpActionResult> Post([FromBody] Company company)
        {
            try
            {

                dataContext.Companys.Add(company);
                await dataContext.SaveChangesAsync();
                return Ok("success");

                //הדרך הישנה
                //dataContext.Companys.Add(company);
                //dataContext.SaveChanges();
                //return Ok(new { company });
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // PUT: api/Company/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]Company company)
        {
            try
            {
                Company companyUser = dataContext.Companys.First((itemID) => itemID.Id == id);
                companyUser.NameCompany = company.NameCompany;
                companyUser.City = company.City;
                dataContext.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Company/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Company Company = dataContext.Companys.First((itemID) => itemID.Id == id);
                dataContext.Companys.Remove(Company);
                dataContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
