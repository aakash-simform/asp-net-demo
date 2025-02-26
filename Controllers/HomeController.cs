using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Index Action to fetch data and show it in the view
        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();
            return View(students); // Pass data to view
        }
    }
}

