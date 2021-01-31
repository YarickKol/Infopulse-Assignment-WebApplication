using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Repositories.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; set; }
        IOrderRepository Orders { get; set; }
        ICustomerRepository Customers { get; set; }
    }
}
