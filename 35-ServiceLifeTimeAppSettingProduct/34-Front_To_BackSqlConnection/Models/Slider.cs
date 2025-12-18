using task777.Models.Base;

namespace task777.Models
{
    public class Slider: BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

    }
}