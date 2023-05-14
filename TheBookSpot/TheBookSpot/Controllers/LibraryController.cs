using Microsoft.AspNetCore.Mvc;
using TheBookSpot.Data;

namespace TheBookSpot.Controllers
{
    public class LibraryController : Controller
    {
        private readonly AppDbContext _context;

        public LibraryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Libraries.ToList();
            return View();
        }
    }
}
