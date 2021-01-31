using Microsoft.EntityFrameworkCore;
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
            if (item == null)
                throw new ArgumentNullException(nameof(item));
           
            _context.Entry(item).State = EntityState.Added;
            SaveChanges();
        }

        public void DeleteItem(int id)
        {
            Customer customer = GetItemById(id);
            if (customer != null)
            {
                _context.Remove(customer);
                SaveChanges();
            }
        }

        public IEnumerable<Customer> GetAllItems()
        {
            return _context.Customers.ToList();
        }

        public Customer GetItemById(int id)
        {
            return _context.Customers.SingleOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(Customer item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
