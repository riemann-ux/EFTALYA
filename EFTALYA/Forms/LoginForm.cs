using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Managers;

namespace EFTALYA.Forms
{
    public partial class LoginForm : Form
    {
        private LoginManager loginManager;
        public LoginForm()
        {
            InitializeComponent();
            loginManager = new LoginManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginManager.LoginProcess(txtEmail.Text.Trim(), txtPassword.Text.Trim()))
            {
                string name = loginManager.EmployeeName(txtEmail.Text.Trim());
                MainForm mainForm = new MainForm(name);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or email.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
