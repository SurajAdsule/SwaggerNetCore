using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.wwwRoot.Model;

namespace WebApplication1.wwwRoot.Model
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _listEmployees;
        public Employee GetEmployee(int id)
        {
            _listEmployees = new List<Employee>()
            {
                new Employee() {Id=1, Name="Suraj"}
            };

            return _listEmployees;

        }
    }
}
