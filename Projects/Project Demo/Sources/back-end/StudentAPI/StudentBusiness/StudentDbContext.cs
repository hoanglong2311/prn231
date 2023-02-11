using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BusinessObject;

namespace BusinessObject
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("StudentDB"));
        }
        public virtual DbSet<StudentModel>? Students { get; set; }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
        }
    }
}
