using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersProducts = new HashSet<OrdersProducts>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? PaymentDate { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<OrdersProducts> OrdersProducts { get; set; }
    }
}
