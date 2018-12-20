using System.Collections.Generic;

namespace TodoApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(long id);
        T Insert(T item);
    }
}