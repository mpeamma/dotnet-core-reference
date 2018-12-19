using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq;
using TodoApi.Core;
using TodoApi.Models;  
using TodoApi.Repositories;

namespace TodoApi.Controllers { 

    [Route("api/[controller]")]     
    [ApiController]     
    public class TodoController : ControllerBase     
    {        
        private readonly BaseContext _context;          
        private readonly IRepository<TodoItem> _todoRepository;

        public TodoController(IRepository<TodoItem> todoRepository, BaseContext context)         
        {      
            _todoRepository = todoRepository;
            _context = context;    
        }
        [HttpGet] 
        public ActionResult<List<TodoItem>> GetAll() 
        {     
            return _context.TodoItems.ToList(); 
        } 
        
        [HttpGet("{id}", Name = "GetTodo")] 
        public ActionResult<TodoItem> GetById(long id) 
        {    
            //var item = _context.TodoItems.Find(id);     
            var item = _todoRepository.GetById(id);
            if (item == null)    
            {         
                return NotFound();     
            }     
            return item; 
        }  

        [HttpPost("")]
        public ActionResult<TodoItem> Create(TodoItem item) 
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }         
    } 
}