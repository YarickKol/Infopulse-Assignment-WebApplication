using Microsoft.EntityFrameworkCore;
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
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Entry(item).State = EntityState.Added;
            SaveChanges();
        }

        public void DeleteItem(int id)
        {
            Product product = GetItemById(id);
            if (product != null)
            {
                _context.Remove(product);
                SaveChanges();
            }
        }

        public IEnumerable<Product> GetAllItems()
        {
            return _context.Products.ToList();
        }

        public Product GetItemById(int id)
        {
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(Product item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
