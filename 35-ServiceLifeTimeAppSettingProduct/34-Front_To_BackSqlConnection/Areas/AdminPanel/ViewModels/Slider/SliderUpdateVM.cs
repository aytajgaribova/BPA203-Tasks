namespace task777.AdminPanel.ViewModels.sliders
{
    public class SliderUpdateVM
    {
          public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }

        public int Order { get; set; }
        public IFormFile? Photo { get; set; }
    }
}