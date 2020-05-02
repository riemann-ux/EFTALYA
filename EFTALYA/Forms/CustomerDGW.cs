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
    public partial class CustomerDGW : Form
    {
        private CustomerManager customerManager;
        public CustomerDGW()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
        }

        private void CustomerDGW_Load(object sender, EventArgs e)
        {
            customerManager.DataGridViewAllList(grdCustomer);
        }

        private void grdCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderForm.id = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
