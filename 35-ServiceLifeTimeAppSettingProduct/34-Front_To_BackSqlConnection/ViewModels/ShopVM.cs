using task777.Models;

namespace task777.ModelsView
{
    public class ShopVM
    {
        public Product Product { get; set; }
        public List<Product> RelatedProducts { get; set; }
    }
}