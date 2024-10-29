using Microsoft.EntityFrameworkCore;
using MyWebApi.Models; // Измени на пространство имён, где находятся твои модели

namespace MyWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } // Добавь DbSet для других моделей
    }
}
