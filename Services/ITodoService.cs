using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoService 
    {
        TodoItem GetById(long id);
    }   
}