namespace E_Ticaret.DTOs.Product
{
    public class CreateProductDto
    {
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
