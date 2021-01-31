using OnlineOrdersWebApp.Models;
using OnlineOrdersWebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        OrdersDbContext _context;
        public CustomerRepository(OrdersDbContext context)
        {
            _context = context;
        }

        public void CreateItem(Customer item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Customer item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Customer GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
