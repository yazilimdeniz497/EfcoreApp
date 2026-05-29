using EfcoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfcoreApp.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly DataContext _context;
        public OgrenciController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ogrenciler.ToListAsync());
        }
        [HttpGet]
        public IActionResult CreateOgrenci()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOgrenci(Ogrenci ogrenci, IFormFile ImageFıle)
        {
            var allowedExtensions = new[] { ".jpg", ".png" };
            var extension = Path.GetExtension(ImageFıle.FileName);
            var randomFile = String.Format(Guid.NewGuid().ToString(),extension);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/",randomFile);
            using (var stream = new FileStream(path, FileMode.Create))
            {
               await ImageFıle.CopyToAsync(stream);


            }

            ogrenci.ImageFıle = randomFile;
            _context.Ogrenciler.Add(ogrenci);
     _context.SaveChanges();

           return View();
        }
    }

    
    }
    

