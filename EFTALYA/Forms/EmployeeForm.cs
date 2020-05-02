using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Managers;

namespace EFTALYA.Forms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeManager employeeManager;
        public EmployeeForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeManager.EmployeeDGW(grdEmployee);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (employeeManager.AddEmployee(txtEmployeeName.Text,txtEmployeeLastname.Text,txtEmployeeEmail.Text,txtEmployeePassword.Text))
            {
                MessageBox.Show("Saved.");
                Clear();
            }

            employeeManager.EmployeeDGW(grdEmployee);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdEmployee.SelectedRows[0].Cells[0].Value);
            if (employeeManager.UpdateEmployee(id, txtEmployeeName.Text, txtEmployeeLastname.Text, txtEmployeeEmail.Text, txtEmployeePassword.Text))
            {
                MessageBox.Show("Updated.");
                Clear();
            }
            employeeManager.EmployeeDGW(grdEmployee);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdEmployee.SelectedRows[0].Cells[0].Value);
            if (employeeManager.DeleteEmployee(id))
            {
                MessageBox.Show("Deleted.");
                Clear();
            }
            employeeManager.EmployeeDGW(grdEmployee);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtEmployeeLastname.Text = string.Empty;
            txtEmployeeEmail.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeePassword.Text = string.Empty;
        }
        

        private void grdEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow row = grdEmployee.Rows[index];
                txtEmployeeName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtEmployeeLastname.Text = row.Cells["EmployeeLastname"].Value.ToString();
                txtEmployeeEmail.Text = row.Cells["EmployeeEmail"].Value.ToString();
                txtEmployeePassword.Text = row.Cells["EmployeePassword"].Value.ToString();
            }
        }

        private void grdEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdEmployee.ClearSelection();
        }
    }
}
