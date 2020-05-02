using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Addresses = new HashSet<Addresses>();
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerEmail { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
