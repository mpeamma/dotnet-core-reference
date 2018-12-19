using System.Collections.Generic;

namespace TodoApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(long id);
    }
}