using OnlineOrdersWebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private OrdersDbContext _context;
        private bool isDisposed = false;

        public IProductRepository Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOrderRepository Orders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICustomerRepository Customers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UnitOfWork()
        {
            _context = new OrdersDbContext();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                _context.Dispose();
                isDisposed = true;
            }
        }
    }
}
