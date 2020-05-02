using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Managers
{
    public class CustomerManager
    {
        EftalyaContext context;
        public CustomerManager()
        {
            context = new EftalyaContext();
        }

        public bool AddCustomer(string customerName, string customerLastname, string customerEmail, string adressStreet, string adressCity, string adressState, int adressZip, string adressCountry)
        {
            if (!string.IsNullOrEmpty(customerName) &&
                !string.IsNullOrEmpty(customerLastname) &&
                !string.IsNullOrEmpty(customerEmail) &&
                !string.IsNullOrEmpty(adressStreet) &&
                !string.IsNullOrEmpty(adressCity) &&
                !string.IsNullOrEmpty(adressState) &&
                !string.IsNullOrEmpty(adressZip.ToString()) &&
                !string.IsNullOrEmpty(adressCountry))
            {
                Customers customer = new Customers
                {
                    CustomerName = customerName,
                    CustomerLastname = customerLastname,
                    CustomerEmail = customerEmail,
                };

                context.Customers.Add(customer);
                context.SaveChanges();

                Addresses addresses = new Addresses
                {
                    CustomerId = customer.CustomerId,
                    AdressStreet = adressStreet,
                    AddressCity = adressCity,
                    AddressState = adressState,
                    AddressZip = adressZip,
                    AddressCountry = adressCountry
                };

                context.Addresses.Add(addresses);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateCustomer(int id, string name, string lastname, string email, string street, string city, string state, int zip, string country)
        {
            List<Customers> customers = context.Customers.ToList().Where(x => x.CustomerId == id).ToList();
            List<Addresses> addresses = context.Addresses.ToList().Where(x => x.CustomerId == id).ToList();
            if (id != null)
            {
                customers[0].CustomerName = name;
                customers[0].CustomerLastname = lastname;
                customers[0].CustomerEmail = email;
                addresses[0].AdressStreet = street;
                addresses[0].AddressCity = city;
                addresses[0].AddressState = state;
                addresses[0].AddressZip = zip;
                addresses[0].AddressCountry = country;
                context.Customers.Update(customers[0]);
                context.SaveChanges();
                context.Addresses.Update(addresses[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            List<Customers> customers = context.Customers.ToList().Where(x => x.CustomerId == id).ToList();
            List<Addresses> addresses = context.Addresses.ToList().Where(x => x.CustomerId == id).ToList();
            List<Orders> order = context.Orders.ToList().Where(x => x.CustomerId == id).ToList();
            if (id != null)
            {
                context.Addresses.Remove(addresses[0]);
                context.SaveChanges();
                context.Orders.Remove(order[0]);
                context.SaveChanges();
                context.Customers.Remove(customers[0]);
                context.SaveChanges();
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DataGridViewAllList(DataGridView dataGridView)
        {
            dataGridView.DataSource = (from c in context.Customers
                                       join a in context.Addresses on c.CustomerId equals a.CustomerId
                                       where c.CustomerId == a.CustomerId
                                       select new
                                       {
                                           Id = c.CustomerId,
                                           Name = c.CustomerName,
                                           Lastname = c.CustomerLastname,
                                           Email = c.CustomerEmail,
                                           Street = a.AdressStreet,
                                           City = a.AddressCity,
                                           State = a.AddressState,
                                           Zip = a.AddressZip,
                                           Country = a.AddressCountry
                                       }
                                       ).ToList();
        }
    }
}