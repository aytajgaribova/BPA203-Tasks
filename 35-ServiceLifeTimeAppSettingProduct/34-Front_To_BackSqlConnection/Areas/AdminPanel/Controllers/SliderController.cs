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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SliderCreateVM sliderCreateVM)
        {
            if(!ModelState.IsValid) return View();


            if (!sliderCreateVM.Photo.ValidatorType("image/"))
            {
                ModelState.AddModelError("Photo", "File type is incorrect!");
                return View();
            }

            if (!sliderCreateVM.Photo.ValidatorSize(FileSize.MB, sliderCreateVM.Photo.Length))
            {
                ModelState.AddModelError("Photo", "File size must be less than 2 mb");
                return View();
            }

            Slider slider=new Slider();
            {
                Title= sliderCreateVM.Title,
                SubTitle=sliderCreateVM.SubTitle,
                Description=sliderCreateVM.Description,
                Order=sliderCreateVM.Order,
                ImageURL= await sliderCreateVM.Photo.CreateFileAsync(_env.WebRootPath,"assets","Images","website-images")
            };



            await _context.Sliders.AddAsync(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            SliderCreateVM sliderCreateVM  = await _context.SliderCreateVM.FirstOrDefaultAsync(s=>s.Id == id);

            if (sliderCreateVM == null) return NotFound();

            sliderCreateVM.ImageURL.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");

            _context.Sliders.Remove(sliderCreateVM);

            await _context.SaveChangesAsync(); 

            return RedirectToAction(nameof(Index));
      
        }

       public async Task<IActionResult> Update(int? id, SliderUpdateVM sliderUpdateVM)
       {
         if (id is null || id < 1) return BadRequest();

            Slider slider  = await _context.Sliders.FirstOrDefaultAsync(s=>s.Id == id);

            if (slider == null) return NotFound();

            SliderUpdateVM sliderUpdateVM1=new();
            {
                Title= sliderUpdateVM.Title,
                SubTitle=sliderUpdateVM.SubTitle,
                Description=sliderUpdateVM.Description,
                Order=sliderUpdateVM.Order,
                ImageURL= await sliderUpdateVM.Photo.CreateFileAsync(_env.WebRootPath,"assets","Images","website-images")
            };


            if (!ModelState.IsValid)
            {
                
             return View(SliderUpdateVM);
            }

        if(sliderUpdateVM.Photo is not null)
            {
                if (!sliderUpdateVM.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError(nameof(sliderUpdateVM.Photo), "File type is incorrect");
                    return View();
                }

            }
       }

    }
}