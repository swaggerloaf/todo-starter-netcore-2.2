using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using todo_starter_netcore_2.Data.Entities;

namespace todo_starter_netcore_2.Data
{
  public class TodoContext : IdentityDbContext
  {
    public DbSet<Todo> Todos { get; set; }
    public DbSet<Todo> Tasks { get; set; }
    public DbSet<User> TodoUsers { get; set; }
    public DbSet<TodoAppUser> TodoAppUsers { get; set; }

    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=todos.db;");
    }
  }
}
