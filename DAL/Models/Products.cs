using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Products
    {
        public Products()
        {
            OrdersProducts = new HashSet<OrdersProducts>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }

        public virtual ICollection<OrdersProducts> OrdersProducts { get; set; }
    }
}
