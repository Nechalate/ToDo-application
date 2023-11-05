using Microsoft.EntityFrameworkCore;

namespace Task_planner.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<TaskStatus> Statuses { get; set; } = null!;
        public DbSet<TaskCategory> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskCategory>().HasData(
                new TaskCategory { CategoryId = "work", Name = "Work"},
                new TaskCategory { CategoryId = "home", Name = "Home"},
                new TaskCategory { CategoryId = "call", Name = "Contact"},
                new TaskCategory { CategoryId = "shop", Name = "Shopping" },
                new TaskCategory { CategoryId = "exercise", Name = "Exercise"}
            );

            modelBuilder.Entity<TaskStatus>().HasData(
                new TaskStatus { StatusId = "open", Name = "Open"},
                new TaskStatus { StatusId = "closed", Name = "Completed"}
            );
        }
    }
}
