using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TodoApi.Core;

namespace TodoApi.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BaseContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(BaseContext context) 
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(long id)
        {
            return _dbSet.Find(new object[] { id });
        }

        public T Insert(T item) 
        {
            _dbSet.Add(item);
            return item;
        }
    }
}