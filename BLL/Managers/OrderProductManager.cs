using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Managers
{
    public class OrderProductManager
    {
        private EftalyaContext context;
        public OrderProductManager()
        {
            context = new EftalyaContext();
        }

        public bool OrderProductAdd(int orderId, int productId, int productQuantity)
        {
            OrdersProducts ordersProduct = new OrdersProducts
            {
                OrderId = orderId,
                ProductId = productId,
                OrderQuantity = productQuantity
            };
            context.OrdersProducts.Add(ordersProduct);
            context.SaveChanges();
            return true;
        }

        public void OrderProductDGW(DataGridView dataGridView)
        {
            dataGridView.DataSource = context.OrdersProducts.ToList();
        }

        public bool DeleteOrderProduct(int id)
        {
            List<OrdersProducts> ordersProducts =
                context.OrdersProducts.ToList().Where(x => x.OrderProductId == id).ToList();

            if (id != null)
            {
                context.OrdersProducts.Remove(ordersProducts[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateOrderProducts(int id, int orderId, int productId, int orderQuantity)
        {
            List<OrdersProducts> orderProducts = context.OrdersProducts.ToList().Where(x => x.OrderProductId == id).ToList();
            if (id != null)
            {
                orderProducts[0].OrderId = orderId;
                orderProducts[0].ProductId = productId;
                orderProducts[0].OrderQuantity = orderQuantity;

                context.OrdersProducts.Update(orderProducts[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        
    }
}
