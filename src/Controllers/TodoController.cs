using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq;
using TodoApi.Core;
using TodoApi.Models;  
using TodoApi.Repositories;
using TodoApi.Services;

namespace TodoApi.Controllers { 

    [Route("api/[controller]")]     
    [ApiController]     
    public class TodoController : ControllerBase     
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)         
        {      
            _todoService = todoService;
        }
        [HttpGet] 
        public ActionResult<List<TodoItem>> GetAll() 
        {     
            return _todoService.GetAll().ToList();
        } 
        
        [HttpGet("{id}", Name = "GetTodo")] 
        public ActionResult<TodoItem> GetById(long id) 
        { 
            var item = _todoService.GetById(id);
            if (item == null)    
            {         
                return NotFound();     
            }     
            return item; 
        }  

        [HttpPost("")]
        public ActionResult<TodoItem> Create(TodoItem item) 
        {
            return _todoService.CreateTodo(item);
        }         
    } 
}