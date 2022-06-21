namespace WebAPI.Models
{
    public class ProductVM
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    public class Product : ProductVM
    {
        public Guid id { get; set; }
    }
}
