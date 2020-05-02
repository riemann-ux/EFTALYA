using BLL.Managers;
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
    public partial class OrderForm : Form
    {
        public static int id;
        private OrderManager orderManager;
        public OrderForm()
        {
            InitializeComponent();
            orderManager = new OrderManager();
        }

        private void btnCustomerDGW_Click(object sender, EventArgs e)
        {
            CustomerDGW customerDGW = new CustomerDGW();
            customerDGW.ShowDialog();
            txtCustomerId.Text = id.ToString();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            orderManager.DataGridViewOrder(grdOrder);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (orderManager.AddOrder(Convert.ToInt32(txtCustomerId.Text), dateInvoice.Value, dateDelivery.Value, datePayment.Value))
            {
                MessageBox.Show("Added.");
                Clear();
            }
            orderManager.DataGridViewOrder(grdOrder);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdOrder.SelectedRows[0].Cells[0].Value);
            int customerId = Convert.ToInt32(txtCustomerId.Text);
            if (orderManager.UpdateOrder(id, customerId, dateInvoice.Value,dateDelivery.Value,datePayment.Value))
            {
                MessageBox.Show("Updated");
                Clear();
            }
            orderManager.DataGridViewOrder(grdOrder);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdOrder.SelectedRows[0].Cells[0].Value);
            if (orderManager.DeleteOrder(id))
            {
                MessageBox.Show("Deleted."); 
                Clear();
            }
            orderManager.DataGridViewOrder(grdOrder);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtCustomerId.Text = string.Empty;
            dateInvoice.Text = string.Empty;
            dateDelivery.Text = string.Empty;
            datePayment.Text = string.Empty;
        }

        private void grdOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow row = grdOrder.Rows[index];
                txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                dateDelivery.Text = row.Cells["DeliveryDate"].Value.ToString();
                datePayment.Text = row.Cells["PaymentDate"].Value.ToString();
                dateInvoice.Text = row.Cells["InvoiceDate"].Value.ToString();
            }
        }
        private void grdOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdOrder.ClearSelection();
        }

        
    }
}
