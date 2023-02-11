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
            var builder = new ConfigurationBuilder().AddJsonFile("D:\\Study at FPTU\\Major 8\\PRN231\\PRN_DEMO_Present\\prn231\\Projects\\Project Demo\\Sources\\back-end\\StudentAPI\\StudentBusiness\\appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("StudentDB"));
        }
        public virtual DbSet<StudentModel>? Students { get; set; }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<StudentModel>().HasKey(e => e.ID);
        }
    }
}
