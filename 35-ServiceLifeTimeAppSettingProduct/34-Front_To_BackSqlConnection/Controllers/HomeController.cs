using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using task777.DAL;
using task777.Models;
using task777.ModelsView;
namespace task777.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders= _context.Sliders.OrderBy(s=>s.Order).ToList();
             List< Product> products= _context.Products.Include(p=>p.ProductImages ).ToList();
  
           
            HomeVM homeVM = new HomeVM
            {
             Sliders=sliders,
             Products=products, 
            };


            var features = await _context.ServiceFeature.OrderBy(f => f.order).ToListAsync();

            return View(features);
        }






    }
}
