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
    public partial class ProductDGW : Form
    {
        private ProductManager productManager;
        public ProductDGW()
        {
            InitializeComponent();
            productManager = new ProductManager();
        }

        private void ProductDGW_Load(object sender, EventArgs e)
        {
            productManager.ProductDGW(grdProduct);
        }

        private void grdProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderProduct.productId = Convert.ToInt32(grdProduct.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
