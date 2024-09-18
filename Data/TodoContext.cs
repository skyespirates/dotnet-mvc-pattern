using demo_app.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_app.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoModel> Todos {  get; set; }
    }
}
