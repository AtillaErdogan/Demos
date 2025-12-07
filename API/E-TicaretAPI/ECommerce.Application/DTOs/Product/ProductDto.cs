namespace E_Ticaret.DTOs.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? CategoryName { get; set; }
    }
}
