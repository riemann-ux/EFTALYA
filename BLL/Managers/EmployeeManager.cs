using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL.Models;

namespace BLL.Managers
{
    public class EmployeeManager
    {
        private EftalyaContext context;

        public EmployeeManager()
        {
            context = new EftalyaContext();
        }

        public bool AddEmployee(string employeeName, string employeeLastname, string employeeEmail, string employeePassword)
        {
            if (!string.IsNullOrEmpty(employeeName) && !string.IsNullOrEmpty(employeeLastname) && !string.IsNullOrEmpty(employeeEmail) && !string.IsNullOrEmpty(employeePassword) )
            {
                Employees employee = new Employees
                {
                    EmployeeName = employeeName,
                    EmployeeLastname = employeeLastname,
                    EmployeeEmail = employeeEmail,
                    EmployeePassword = employeePassword
                };
                context.Employees.Add(employee);
                context.SaveChanges();
                return true;
            }
            else
            {
                //operations..
                return false;
            }
        }

        public bool UpdateEmployee(int id, string employeeName, string employeeLastname, string employeeEmail,
            string employeePassword)
        {
            List<Employees> employee = context.Employees.ToList().Where(x => x.EmployeeId == id).ToList();
            if (id != null)
            {
                employee[0].EmployeeName = employeeName;
                employee[0].EmployeeLastname = employeeLastname;
                employee[0].EmployeeEmail = employeeEmail;
                employee[0].EmployeePassword = employeePassword;
                context.Employees.Update(employee[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DeleteEmployee(int id)
        {
            List<Employees> employee = context.Employees.ToList().Where(x => x.EmployeeId == id).ToList();
            if (id != null)
            {
                context.Employees.Remove(employee[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EmployeeDGW(DataGridView dataGridView)
        {
            dataGridView.DataSource = context.Employees.ToList();
        }
    }
}