using OnlineOrdersWebApp.Repositories.Interfaces;

namespace OnlineOrdersWebApp.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private OrdersDbContext _context;

        private IProductRepository productRepository;
        private IOrderRepository orderRepository;
        private ICustomerRepository customerRepository;
        private bool isDisposed = false;

        public IProductRepository Products { 
            get => productRepository ?? (productRepository = new ProductRepository(_context)); 
            set => productRepository = value; 
        }
        public IOrderRepository Orders {
            get => orderRepository ?? (orderRepository = new OrderRepository(_context));
            set => orderRepository = value; 
        }
        public ICustomerRepository Customers { 
            get => customerRepository ?? (customerRepository = new CustomerRepository(_context)); 
            set => customerRepository = value; 
        }

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
