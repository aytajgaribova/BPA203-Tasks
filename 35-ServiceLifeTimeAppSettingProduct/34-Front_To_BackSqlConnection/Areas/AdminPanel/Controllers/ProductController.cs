using Front_To_Back_.DAL;
using Front_To_Back_.Models;
using Front_To_Back_.Utilities.Enums;
using Front_To_Back_.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using task777.AdminPanel.ViewModels;
using task777.AdminPanel.ViewModels.sliders;
using task777.Models;

namespace Front_To_Back_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<GetProductVM> getProductVMs=await _context.Products
            .Include(p=>p.ProductImages)
            .Include(p=>p.Category)
            .Select(p=>new GetProductVM
            {
                Name=p.Name,
                Price=p.Price,
                CategoryName=p.Category.Name,
                ImageURL=p.ProductImages.Where(pi=>pi.IsPriamry==true).FirstOrDefault().ImageURL
            })
            .ToListAsync();

        return View(getProductVMs);

        }

        public async Task<IActionResult> Create()
        {
            List<Category> categories=await _context.Categories.ToListAsync();
            List<Tags> tags=await _context.Categories.ToListAsync();
            CreateProductVM createProductVM = new()
            {
                Tags=tags,
                Categories=categories
            };
            return View(createProductVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVM createProductVM)
        {
          createProductVM.Categories = await _context.Categories.ToListAsync();

          if (createProductVM.Price<0)
          {
            ModelState.AddModelError(nameof(CreateProductVM.Price), "Price does not  negative!");
          }
         
            return View(createProductVM);

            bool exsistCategory=createProductVM.Categories.Any(c=>c.Id == createProductVM.CategoryID);
            if (!exsistCategory)
            {
                ModelState.AddModelError(nameof(CreateProductVM.CategoryID), "category does not exsist!");
                return View(createProductVM);
            }
        }

    }
    }