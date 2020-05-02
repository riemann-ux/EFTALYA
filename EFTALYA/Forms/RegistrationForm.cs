using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Managers;

namespace EFTALYA.Forms
{
    public partial class RegistrationForm : Form
    {
        private EmployeeManager employeeManager;
        public RegistrationForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Form Motion

        private int move;
        private int mouse_x;
        private int mouse_y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61)- mouse_x, (MousePosition.Y)-mouse_y);
            }
        }

        #endregion

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (employeeManager.AddEmployee(txtEmployeeName.Text.Trim(), txtEmployeeLastname.Text.Trim(),
                txtEmployeeEmail.Text.Trim(), txtEmployeePassword.Text.Trim()))
            {
                MessageBox.Show("Congratulations!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faul!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure?","Information",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult== DialogResult.Yes )
            {
                this.Close();
            }
            else
            {
                //operations..
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtEmployeeName.Text = string.Empty;
            txtEmployeeLastname.Text = string.Empty;
            txtEmployeeEmail.Text = string.Empty;
            txtEmployeePassword.Text = string.Empty;
        }

        private void cboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShow.Checked == true)
            {
                txtEmployeePassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtEmployeePassword.UseSystemPasswordChar = true;
            }
        }
    }
}
