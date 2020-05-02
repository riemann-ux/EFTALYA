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
    public partial class OrderProduct : Form
    {
        public static int orderId;
        public static int productId;
        private OrderProductManager orderProductManager;
        public OrderProduct()
        {
            InitializeComponent();
            orderProductManager = new OrderProductManager();
        }

        private void btnOrderDGW_Click(object sender, EventArgs e)
        {
            OrderDGW orderDGW = new OrderDGW();
            orderDGW.ShowDialog();
            txtOrderId.Text = orderId.ToString();
        }

        private void btnProductDGW_Click(object sender, EventArgs e)
        {
            ProductDGW productDGW = new ProductDGW();
            productDGW.ShowDialog();
            txtProductId.Text = productId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            orderProductManager.OrderProductAdd(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtProductId.Text), Convert.ToInt32(txtProductQuantity.Text));
            MessageBox.Show("Başarılı.");
            orderProductManager.OrderProductDGW(grdOrderProduct);
        }

        private void OrderProduct_Load(object sender, EventArgs e)
        {
            orderProductManager.OrderProductDGW(grdOrderProduct);
        }

        private void grdOrderProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow row = grdOrderProduct.Rows[index];
                txtOrderId.Text = row.Cells["OrderId"].Value.ToString();
                txtProductId.Text = row.Cells["ProductId"].Value.ToString();
                txtProductQuantity.Text = row.Cells["OrderQuantity"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdOrderProduct.SelectedRows[0].Cells[0].Value);
            if (orderProductManager.DeleteOrderProduct(id))
            {
                MessageBox.Show("Deleted.");
                Clear();
            }
            orderProductManager.OrderProductDGW(grdOrderProduct);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdOrderProduct.SelectedRows[0].Cells[0].Value);

            if (orderProductManager.UpdateOrderProducts(id,Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtProductId.Text), Convert.ToInt32(txtProductQuantity.Text)))
            {
                MessageBox.Show("Updated."); 
                Clear();
            }
            orderProductManager.OrderProductDGW(grdOrderProduct);
        }

        private void Clear()
        {
            txtProductQuantity.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtOrderId.Text = string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void grdOrderProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdOrderProduct.ClearSelection();

        }
    }
}
