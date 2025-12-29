using task777.Models;

namespace task777.AdminPanel.ViewModels
{
    public class ProductCreateVM
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }

        public int Order { get; set; }
        public IFormFile Photo { get; set; }
        public List<Category>? categories {get; set;}
        public List<Tag>? Tags {get; set;}
        public List<int>? TagIds {get; set;}

    }
}