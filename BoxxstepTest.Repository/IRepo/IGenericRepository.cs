using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Repository.IRepo
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetList();
        Task<T> GetById(long id);
        Task Add(T entity);
        void Delete(long id);
        Task Upsert(T entity);
    }
}
