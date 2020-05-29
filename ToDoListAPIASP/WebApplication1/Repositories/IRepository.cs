using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Create(T item);
        void Remove(int id);
        void Save();
        bool Update(T item);
    }
}
