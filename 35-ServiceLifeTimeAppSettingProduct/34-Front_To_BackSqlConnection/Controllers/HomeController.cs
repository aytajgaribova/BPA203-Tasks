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
        public async Task<IActionResult> Index()
        {
            // List<Slider> sliders= _context.Sliders.OrderBy(s=>s.Order).ToList();
            // List< Product> products= _context.Products.Include(p=>p.ProductImages.Where(pi=>pi.IsPrimary != null) ).ToList();
  
           
            List<Slider> sliders = await _context.Sliders
                .OrderBy(s=>s.Order)
                .ToListAsync();
            List<Shipping> shippings = await _context.Shippings
                .ToListAsync();
            List<Product> products = await _context.Products
                .Include(p => p.ProductImages.Where(pi=>pi.IsPrimary != null))
                .ToListAsync();

            HomeVM homeVM = new HomeVM
            {
           Sliders = sliders,
                Shippings = shippings,
                Products = products
            };
            

            return View(homeVM);

        }






    }
}
