using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace BLL.Managers
{
    public class LoginManager
    {
        private EftalyaContext context;
        public LoginManager()
        {
            context = new EftalyaContext();
        }

        public bool LoginProcess(string _email, string _password)
        {
            List<Employees> employeeses = context.Employees.ToList().FindAll(x=> x.EmployeeEmail.Trim() == _email && x.EmployeePassword == _password);

            if (employeeses.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string EmployeeName(string _email)
        {
            //return context.Employees.ToList().FindAll(x=> x.EmployeeEmail == _email).Select(x => (x.EmployeeName + " " + x.EmployeeLastname)).ToList();
            return context.Employees.ToList().FindAll(x => x.EmployeeEmail == _email)[0].EmployeeName + " " + context.Employees.ToList().FindAll(x => x.EmployeeEmail == _email)[0].EmployeeLastname;
        }
    }
}