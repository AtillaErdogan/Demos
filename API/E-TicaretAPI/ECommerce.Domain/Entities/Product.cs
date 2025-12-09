using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Entities
{
    public class Product :IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public decimal Price { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
