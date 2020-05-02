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
    public partial class ProductForm : Form
    {
        private ProductManager productManager;
        public ProductForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            productManager.ProductDGW(grdProduct);
            grdProduct.Columns[5].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (productManager.AddProduct(txtProdcutName.Text,txtProductDescription.Text,Convert.ToDecimal(txtProductPrice.Text),Convert.ToInt32(txtProductQuantity.Text)))
            {
                MessageBox.Show("Saved.");
                Clear();
            }
            productManager.ProductDGW(grdProduct);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdProduct.SelectedRows[0].Cells[0].Value);
            if (productManager.UpdateProduct(id, txtProdcutName.Text, txtProductDescription.Text, Convert.ToDecimal(txtProductPrice.Text), Convert.ToInt32(txtProductQuantity.Text)))
            {
                MessageBox.Show("Updated");
                Clear();
            }
            productManager.ProductDGW(grdProduct);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdProduct.SelectedRows[0].Cells[0].Value);
            if (productManager.DeleteProduct(id))
            {
                MessageBox.Show("Deleted.");
                Clear();
            }
            productManager.ProductDGW(grdProduct);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void grdProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdProduct.ClearSelection();
        }

        private void Clear()
        {
            txtProductPrice.Text = string.Empty;
            txtProdcutName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
        }
        private void grdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow row = grdProduct.Rows[index];
                txtProdcutName.Text = row.Cells["ProductName"].Value.ToString();
                txtProductDescription.Text = row.Cells["ProductDescription"].Value.ToString();
                txtProductPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                txtProductQuantity.Text = row.Cells["ProductQuantity"].Value.ToString();
            }
        }
    }
}
