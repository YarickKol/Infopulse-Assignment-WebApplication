using Microsoft.EntityFrameworkCore;
using OnlineOrdersWebApp.Models;
using OnlineOrdersWebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        OrdersDbContext _context;
        public OrderRepository(OrdersDbContext context)
        {
            _context = context;
        }
        public void CreateItem(Order item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Entry(item).State = EntityState.Added;
            SaveChanges();
        }

        public void DeleteItem(int id)
        {
            Order order = GetItemById(id);
            if (order != null)
            {
                _context.Remove(order);
                SaveChanges();
            }
        }

        public IEnumerable<Order> GetAllItems()
        {
            return _context.Orders.ToList();
        }

        public Order GetItemById(int id)
        {
            return _context.Orders.SingleOrDefault(o => o.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(Order item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
