using MvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcApplication.Infrastructure
{
    public class CustomerRepository : IRepository<Customer, string>
    {
        static List<Customer> customerList;
        public CustomerRepository()
        {
            if (customerList == null)
            {
                customerList = new List<Customer>();
                AddItemsList();
            }
           
        }

        private void AddItemsList()
        {
            Customer c1 = new Customer{ CustomerId = "AAAAA",
                CompanyName = "Canarys", ContactName = "Deeps", City = "Banglore", Country = "India" };
            customerList.Add(c1);


            customerList.Add(new Customer
            {
                CustomerId = "BBBBB",
                CompanyName = "Hop On",
                ContactName = "Keerti",
                City = "mysore",
                Country = "India"
            });


            customerList.Add(new Customer
            {
                CustomerId = "CCCCC",
                CompanyName = "Suresh corporation",
                ContactName = "Sneha",
                City = "Mumbai",
                Country = "India"
            });           
        }
        public void CreateNew(Customer item)
        {
            if(item!=null)
            {
                customerList.Add(item);
            }
        }

        public void Delete(string identity)
        {
            if(!string.IsNullOrEmpty(identity))
            {
                customerList.RemoveAll(c => c.CustomerId == identity);
            }
        }

        public IQueryable<Customer> GetAll()
        {
            var query = from d in customerList select d;
            return query.AsQueryable();
        }

        public Customer GetDetails(string identity)
        {
            return customerList.FirstOrDefault(c => c.CustomerId.Equals(identity));
        }

        public void Update(Customer item)
        {
            if (item != null)
            {
                customerList.RemoveAll(c => c.CustomerId == item.CustomerId);
                customerList.Add(item);
            }
        }
    }
}