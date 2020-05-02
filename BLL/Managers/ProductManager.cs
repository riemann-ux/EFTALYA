using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Managers
{
    public class ProductManager
    {
        private EftalyaContext context;
        public ProductManager()
        {
            context = new EftalyaContext();
        }

        public bool AddProduct(string productName, string productDescription, decimal productPrice, int productQuantity)
        {
            if (!string.IsNullOrEmpty(productName) &&
                !string.IsNullOrEmpty(productDescription) &&
                !string.IsNullOrEmpty(productPrice.ToString()) &&
                !string.IsNullOrEmpty(productQuantity.ToString()))
            {
                Products products = new Products
                {
                    ProductName = productName,
                    ProductDescription = productDescription,
                    ProductPrice = productPrice,
                    ProductQuantity = productQuantity
                };
                context.Products.Add(products);
                context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool UpdateProduct(int id, string productName, string productDescription, decimal productPrice, int productQuantity)
        {
            List<Products> product = context.Products.ToList().Where(x => x.ProductId == id).ToList();

            if (id != null)
            {
                product[0].ProductName = productName;
                product[0].ProductDescription = productDescription;
                product[0].ProductPrice = productPrice;
                product[0].ProductQuantity = productQuantity;
                context.Products.Update(product[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            List<Products> product = context.Products.ToList().Where(x => x.ProductId == id).ToList();
            if (id != null)
            {
                context.Products.Remove(product[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ProductDGW(DataGridView dataGridView)
        {
            dataGridView.DataSource = context.Products.ToList();
        }
    }
}
