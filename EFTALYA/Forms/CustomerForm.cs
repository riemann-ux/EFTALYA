using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BLL.Managers;
using DAL.Models;

namespace EFTALYA.Forms
{
    public partial class CustomerForm : Form
    {
        BLL.Managers.CustomerManager customerManager;
        DAL.Models.EftalyaContext context;
        public CustomerForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            context = new EftalyaContext();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customerManager.DataGridViewAllList(grdCustomer);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (customerManager.AddCustomer(txtCustomerName.Text, txtCustomerLastname.Text, txtCustomerEmail.Text,
                txtCustomerStreet.Text, txtCustomerCity.Text, txtCustomerState.Text,
                Convert.ToInt32(txtCustomerZip.Text), txtCustomerCountry.Text))
            {
                MessageBox.Show("Saved.");
                Clear();
            }
            customerManager.DataGridViewAllList(grdCustomer);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
            if (customerManager.UpdateCustomer(id, txtCustomerName.Text.Trim(), txtCustomerLastname.Text.Trim(),
                txtCustomerEmail.Text.Trim(), txtCustomerStreet.Text.Trim(), txtCustomerCity.Text.Trim(),
                txtCustomerState.Text.Trim(), Convert.ToInt32(txtCustomerZip.Text.Trim()),
                txtCustomerCountry.Text.Trim()))
            {
                MessageBox.Show("Updated.");
                Clear();
            }
            customerManager.DataGridViewAllList(grdCustomer);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
            if (customerManager.DeleteCustomer(id))
            {
                MessageBox.Show("Deleted."); Clear();
            }
            customerManager.DataGridViewAllList(grdCustomer);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerLastname.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;
            txtCustomerStreet.Text = string.Empty;
            txtCustomerCity.Text = string.Empty;
            txtCustomerState.Text = string.Empty;
            txtCustomerZip.Text = string.Empty;
            txtCustomerCountry.Text = string.Empty;
        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1 )
            {
                DataGridViewRow row = grdCustomer.Rows[index];
                txtCustomerName.Text = row.Cells["Name"].Value.ToString();
                txtCustomerLastname.Text = row.Cells["Lastname"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["Email"].Value.ToString();
                txtCustomerStreet.Text = row.Cells["Street"].Value.ToString();
                txtCustomerCity.Text = row.Cells["City"].Value.ToString();
                txtCustomerState.Text = row.Cells["State"].Value.ToString();
                txtCustomerZip.Text = row.Cells["Zip"].Value.ToString();
                txtCustomerCountry.Text = row.Cells["Country"].Value.ToString();

            }
        }

        private void grdCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdCustomer.ClearSelection();
        }
    }
}
