using task777.Models.Base;
namespace task777.Models
{
public class ServiceFeature : baseentity
{

    public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public int Order {get; set;}
}
}