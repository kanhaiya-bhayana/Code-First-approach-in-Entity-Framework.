global using Microsoft.EntityFrameworkCore;
using demoLoginApi.Models;

namespace demoLoginApi.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=G1-1MS2MQ3-L;Initial Catalog=crudRepoPattern; TrustServerCertificate=True; Integrated Security=True ");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
