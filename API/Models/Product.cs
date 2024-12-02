namespace API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }
    }
}
