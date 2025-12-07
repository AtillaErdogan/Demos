using ECommerce.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ECommerce.Configurations
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {   // Primary Key
            builder.HasKey(x => x.Id);
            // Identity
            builder.Property(x => x.Id).UseIdentityColumn();

        }
    }
}
