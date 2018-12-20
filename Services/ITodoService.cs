using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoService 
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem GetById(long id);
        TodoItem CreateTodo(TodoItem item);
    }   
}