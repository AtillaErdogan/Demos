namespace Demo2.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        // Navigation
        public Category Category { get; set; }
    }
}
