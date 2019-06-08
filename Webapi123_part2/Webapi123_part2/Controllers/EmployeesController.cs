using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapi123_part2.Models;

namespace Webapi123_part2.Controllers
{
    public class EmployeesController : ApiController
    {
        public IHttpActionResult Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return Ok(entities.Employees.ToList());
            }
        }
    }
}
