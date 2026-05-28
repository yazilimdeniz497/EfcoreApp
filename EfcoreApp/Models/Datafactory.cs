using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfcoreApp.Models
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=DENIZ\\MSSQLSERVER08;Database=BootcampDb;Integrated Security=True;TrustServerCertificate=True");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
