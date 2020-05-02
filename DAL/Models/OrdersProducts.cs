using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OrdersProducts
    {
        public int OrderProductId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderQuantity { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
