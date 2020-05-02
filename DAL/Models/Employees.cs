using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
    }
}
