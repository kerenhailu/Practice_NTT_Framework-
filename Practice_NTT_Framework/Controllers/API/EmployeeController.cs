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
    public class EmployeeController : ApiController
    {
        DataContext dataContext = new DataContext();
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            List<Employees> ListEmployees = dataContext.Employees.ToList();
            return Ok(new { ListEmployees });
        }

        // GET: api/Employee/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Employees Employee = await dataContext.Employees.FindAsync(id);

                //הישן
                //Employees Employee = dataContext.Employees.First((itemID) => itemID.Id == id);
                return Ok(new { Employee });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Employee
        public async Task<IHttpActionResult> Post([FromBody] Employees Employee)
        {
            try
            {
                
                dataContext.Employees.Add(Employee);
                await dataContext.SaveChangesAsync();
                return Ok("success");
                
                //הדרך הישנה
                //dataContext.Employees.Add(Employee);
                //dataContext.SaveChanges();
                //return Ok(new { Employee });
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        // PUT: api/Employee/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Employees Employee)
        {
            try
            {
                Employees EmployeeUser = dataContext.Employees.First((itemID) => itemID.Id == id);
                EmployeeUser.FullName= Employee.FullName;
                EmployeeUser.Age = Employee.Age;
                EmployeeUser.NameClass = Employee.NameClass;
                dataContext.SaveChanges();

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Employee/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Employees Employee = dataContext.Employees.First((itemID) => itemID.Id == id);
                dataContext.Employees.Remove(Employee);
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
