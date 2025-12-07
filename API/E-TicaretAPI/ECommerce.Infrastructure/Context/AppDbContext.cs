using E_Ticaret.Entities;
using Microsoft.EntityFrameworkCore;



namespace ECommerce.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Configurations klasöründeki tüm yapılandırma sınıflarını otomatik olarak uygular.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

         
        }

        
    }
}
