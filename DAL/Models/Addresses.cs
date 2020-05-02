using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Addresses
    {
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string AdressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public int? AddressZip { get; set; }
        public string AddressCountry { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
