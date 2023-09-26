using ItprogerShop.Data;
using ItprogerShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ItprogerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() 
        {
            
            List<Item> items = _context.items.ToList();

            return View(items);
        }

        public IActionResult Product(int id)
        {
            Item item = _context.items.Find(id) ?? new Item();
            return View(item);
        }

        public IActionResult Cups(int id)
        {
            List<Item> items = _context.items.Where(el => el.CategoryID == 1).ToList();
            return View(items);
        }
        public IActionResult Tshirts(int id)
        {
            List<Item> items = _context.items.Where(el => el.CategoryID == 2).ToList();
            return View(items);
        }

        public IActionResult About() // home/about
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}