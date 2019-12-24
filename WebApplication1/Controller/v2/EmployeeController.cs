using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controller.v2
{
    /// <summary>
    /// Employee CRUD operations
    /// </summary>
    [Route("api/v2/Employee/")]
    [ApiExplorerSettings(GroupName = "v2")]
    //[ApiVersion("v2")]
    //[Route("api/v2/[controller]")]
    public class EmployeeController:ControllerBase
    {
        /// <summary>
        /// Get the employee detail like Name, salary
        /// </summary>
        /// <param name="id">Provide Id of employee to get the details</param>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        [Route("GetEmpDetail")]
        [Produces("application/json", "application/xml")]
        
        public EmployeeModel GetEmployee(int id)
        {

            return EmployeeList().Where(a => a.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Create new employee
        /// </summary>
        /// <param name="emp">Add employee details</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddNewEmployee")]
        public ActionResult AddEmployee(EmployeeModel emp)
        {
            return Ok();
        }

        /// <summary>
        /// Delete employee from database
        /// </summary>
        /// <param name="id">Provide Id of employee whome you want to delete</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public ActionResult DeleteEmployee(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Update employee details
        /// </summary>
        /// <param name="emp">Provide updated details of employee</param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateEmployeeDetail")]
        public ActionResult EditEmployee(EmployeeModel emp)
        {
            return Ok();
        }

        /// <summary>
        /// List of all employees
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeModel> EmployeeList()
        {
            var empList = new List<EmployeeModel>();
            empList.Add(new EmployeeModel() {
                Id = 1,
                Name = "Suraj",
                Salary = 10,
                Department = "IT"
            });
            empList.Add(new EmployeeModel()
            {
                Id = 2,
                Name = "Isha",
                Salary = 10,
                Department = "IT"
            });
            return empList;
        }
    }

    /// <summary>
    /// Detail of employee
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Employee Id
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Name of employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Salary of employee in INR
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Department name where employee belongs to 
        /// </summary>
        public string Department { get; set; }
    }
}
