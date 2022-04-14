using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbpharaProject
{
    internal class CustomerDal
    {
        public List<Customer> GetList()
        {
            using (ETradeContext context = new ETradeContext())
            {
                var allCustomers = new List<Customer>();
                allCustomers = context.Customers.ToList();
                return allCustomers;
            }
        }

        public void Add(Customer customer)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
    }
}
