using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Core {
    public class BaseContext : DbContext     
    {         
        public BaseContext(DbContextOptions<BaseContext> options): base(options) { }       
        public DbSet<TodoItem> TodoItems { get; set; }     
    } 
}