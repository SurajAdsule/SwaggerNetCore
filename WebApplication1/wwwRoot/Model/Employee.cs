using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.wwwRoot.Model
{
    public class Employee
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
}
