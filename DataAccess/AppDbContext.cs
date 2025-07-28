using Microsoft.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> Gorevler { get; set; }
    }
}
