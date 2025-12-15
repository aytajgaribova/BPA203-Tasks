using task777.Models.Base;

namespace task777.Models
{
    public class Category : baseentity
    {
        public string Name {get; set;}
        public List<Product> Products{get; set;}
        

    }
}