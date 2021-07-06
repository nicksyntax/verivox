using System;
using System.Collections.Generic;
using Verivox.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verivox.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        List<T> GetAll();
        T Get(int id);
    }
}
