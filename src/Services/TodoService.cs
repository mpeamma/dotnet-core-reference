using System.Collections.Generic;
using TodoApi.Core;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly IRepository<TodoItem> _repo;
        private readonly BaseContext _context;
        public TodoService(IRepository<TodoItem> repo, BaseContext context)
        {
            _repo = repo;
            _context = context;
        }

        public TodoItem CreateTodo(TodoItem item)
        {
            _repo.Insert(item);
            _context.SaveChanges();
            return item;
        }

        public TodoItem GetById(long id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _repo.GetAll();
        }
    }
}