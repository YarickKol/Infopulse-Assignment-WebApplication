using OnlineOrdersWebApp.Models;
using OnlineOrdersWebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        OrdersDbContext _context;
        public ProductRepository(OrdersDbContext context)
        {
            _context = context;
        }

        public void CreateItem(Product item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Product item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Product GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
