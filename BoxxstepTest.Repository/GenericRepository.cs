using BoxxstepTest.Repository.Data;
using BoxxstepTest.Repository.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxxstepTest.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _context;
        protected DbSet<T> dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;           
            this.dbSet = context.Set<T>();
        }
        public virtual async Task<IList<T>> GetList()
        {
            return await dbSet.ToListAsync();
        }
        public virtual async Task<T> GetById(long id)
        {
            return await dbSet.FindAsync(id);
        }
        public async Task Add(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public void Delete(long id)
        {
            var entity = dbSet.Find(id);
            if (entity != null) dbSet.Remove(entity);
        }

        public virtual async Task Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
