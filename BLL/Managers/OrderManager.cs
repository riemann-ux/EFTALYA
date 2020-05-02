using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Managers
{
    public class OrderManager
    {
        private EftalyaContext context;
        public OrderManager()
        {
            context = new EftalyaContext();
        }

        public bool AddOrder(int customerId, DateTime invoiceDate, DateTime deliveryDate, DateTime paymentDate)
        {
            Orders order = new Orders
            {
                CustomerId = customerId,
                InvoiceDate = invoiceDate,
                DeliveryDate = deliveryDate,
                PaymentDate = paymentDate
            };

            context.Orders.Add(order);
            context.SaveChanges();
            return true;
        }

        public bool UpdateOrder(int id, int customerId, DateTime invoiceDate, DateTime deliveryDate, DateTime paymentDate)
        {
            List<Orders> order = context.Orders.ToList().Where(x => x.OrderId == id).ToList();
            if (id != null)
            {
                order[0].CustomerId = customerId;
                order[0].InvoiceDate = invoiceDate;
                order[0].DeliveryDate = deliveryDate;
                order[0].PaymentDate = paymentDate;
                context.Orders.Update(order[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteOrder(int id)
        {
            List<Orders> order = context.Orders.ToList().Where(x => x.OrderId == id).ToList();

            if (id != null)
            {
                context.Orders.Remove(order[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DataGridViewOrder(DataGridView dataGridView)
        {
            dataGridView.DataSource = context.Orders.ToList();
        }
    }
}
