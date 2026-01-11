using Microsoft.EntityFrameworkCore;
using rest_api_labb.Application.Models;

namespace rest_api_labb.Application.Context
{
    public class RestApiLabbDbContext : DbContext
    {
        public RestApiLabbDbContext() { }
        public RestApiLabbDbContext(DbContextOptions<RestApiLabbDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string is missing");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
    }
}
