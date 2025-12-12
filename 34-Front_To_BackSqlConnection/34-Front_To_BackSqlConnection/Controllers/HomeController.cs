using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using task777.DAL;
using task777.Models;
using task777.ModelsView;
namespace task777.Controllers
{
    public class HomeController: Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Slider> selectSlider= new List<Slider>();
            HomeVM homeVm = new HomeVM
            {
                sliders = selectSlider
            };


var features= await _context.ServiceFeature.OrderBy(f=> f.order).ToListAsync();

         return View(features);
        }

   




    }
}
