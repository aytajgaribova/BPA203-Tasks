using Microsoft.AspNetCore.Mvc;
using task777.DAL;
using task777.Models;
using task777.ModelsView;
namespace task777.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context=context;
        }
 
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Detail(int? id)
        {
            if (id==null || id<1) return BadRequest();
            // Product? product =_context.Products
            // .Include(p=>p.ProductImages.OrderByDescending(pi=>pi.IsPrimary))
            // .Include(p=>p.Category)
            // .FirstorDefault(p=>p.Id== id);
            // if(product==null) return NotFound(); 

            // List<Product> relatedProducts =_context.Products
            // .Where(rp=>rp.CategoryId== product.CategoryId && rp.Id!= product.Id)
            // .Include(p=>p.ProductImages.Where(pi=>pi.IsPrimary!=null))
            // .ToList();

            ShopVM shopVM= new ShopVM
            {
                // Product=product,
                // RelatedProducts=relatedProducts,
            };

            return View(shopVM);
        }
    }
} 