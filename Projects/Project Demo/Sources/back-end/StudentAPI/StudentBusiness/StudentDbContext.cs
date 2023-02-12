using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("config.json", optional: true, reloadOnChange: true)
                .Build();
            
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("StudentDB"));
        }
        public virtual DbSet<StudentModel>? Students { get; set; }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<StudentModel>().HasKey(e => e.ID);
        }
    }
}
