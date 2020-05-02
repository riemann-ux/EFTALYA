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
    public partial class OrderDGW : Form
    {
        private OrderManager orderManager;
        public OrderDGW()
        {
            InitializeComponent();
            orderManager = new OrderManager();
        }

        private void OrderDGW_Load(object sender, EventArgs e)
        {
            orderManager.DataGridViewOrder(grdOrder);
        }

        private void grdOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderProduct.orderId = Convert.ToInt32(grdOrder.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
