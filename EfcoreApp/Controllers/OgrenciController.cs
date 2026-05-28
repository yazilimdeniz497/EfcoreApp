using EfcoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfcoreApp.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly DataContext _context;
        public OgrenciController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CreateOgrenci()
        {
            return View();
        }
    }
}
