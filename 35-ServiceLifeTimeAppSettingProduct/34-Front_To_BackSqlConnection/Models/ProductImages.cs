using task777.Models.Base;

namespace task777.Models
{
    public class ProductImage: BaseEntity
    {
        public string ImageURL { get; set; }
        public bool? IsPrimary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}