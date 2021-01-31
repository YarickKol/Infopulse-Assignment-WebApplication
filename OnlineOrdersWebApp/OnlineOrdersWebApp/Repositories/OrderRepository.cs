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
            throw new NotImplementedException();
        }

        public void DeleteItem(Order item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Order GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
