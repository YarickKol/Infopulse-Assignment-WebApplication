using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Repositories.Interfaces
{
    public interface IDefaultActions<T>where T:class
    {
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(int id);
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);        
        bool SaveChanges();
    }
}
