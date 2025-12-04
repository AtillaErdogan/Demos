using Demo2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo2.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //OnModelcreating'de yaptığımız ayarları buraya taşıyoruz.

            // Ad Gerekli 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            // Tablolar arası ilişki
            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Category)
                   .HasForeignKey(x => x.CategoryId);

        }
    }
}
