using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTALYA.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string name)
        {
            InitializeComponent();
            lblEmployeeName.Text = name;
        }

        #region Form Move
        int move;
        int mouse_x;
        int mouse_y;

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61) - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            pnlContent.Controls.Clear();
            customerForm.TopLevel = false;
            pnlContent.Controls.Add(customerForm);
            customerForm.Show();
            customerForm.Dock = DockStyle.Fill;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            pnlContent.Controls.Clear();
            orderForm.TopLevel = false;
            pnlContent.Controls.Add(orderForm);
            orderForm.Show();
            orderForm.Dock = DockStyle.Fill;
        }

        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            OrderProduct orderProductForm = new OrderProduct();
            pnlContent.Controls.Clear();
            orderProductForm.TopLevel = false;
            pnlContent.Controls.Add(orderProductForm);
            orderProductForm.Show();
            orderProductForm.Dock = DockStyle.Fill;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            pnlContent.Controls.Clear();
            productForm.TopLevel = false;
            pnlContent.Controls.Add(productForm);
            productForm.Show();
            productForm.Dock = DockStyle.Fill;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            pnlContent.Controls.Clear();
            employeeForm.TopLevel = false;
            pnlContent.Controls.Add(employeeForm);
            employeeForm.Show();
            employeeForm.Dock = DockStyle.Fill;
        }
    }
}
