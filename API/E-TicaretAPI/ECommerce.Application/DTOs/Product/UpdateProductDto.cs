namespace ECommerce.DTOs.Product
{
    public class UpdateProductDto
    {
        // Güncelleme işlemi için Id gereklidir
        //public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
