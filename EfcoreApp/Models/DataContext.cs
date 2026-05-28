using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfcoreApp.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<Bootcamp> Bootcampler => Set<Bootcamp>();
        public DbSet<BootcampKayit> BootcampKayitlar => Set<BootcampKayit>();
        
    }
}
