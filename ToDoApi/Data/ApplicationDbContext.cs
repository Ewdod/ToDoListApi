using Microsoft.EntityFrameworkCore;

namespace ToDoApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ToDo> ToDos => Set<ToDo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var todos = new List<ToDo>
            {
                new ToDo { Id = 1, Title = "Morning exercise", Done = false },
                new ToDo { Id = 2, Title = "Read for 30 minutes", Done = false },
                new ToDo { Id = 3, Title = "Work on project tasks", Done = false },
                new ToDo { Id = 4, Title = "Lunch break", Done = false },
                new ToDo { Id = 5, Title = "Attend team meeting", Done = true },
                new ToDo { Id = 6, Title = "Complete work tasks", Done = true },
                new ToDo { Id = 7, Title = "Dinner", Done = true },
                new ToDo { Id = 8, Title = "Relax and unwind", Done = true },
            };
            modelBuilder.Entity<ToDo>().HasData(todos);
        }
    }
}
