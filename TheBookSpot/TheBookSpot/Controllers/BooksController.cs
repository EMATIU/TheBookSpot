using Microsoft.AspNetCore.Mvc;
using TheBookSpot.Data;

namespace TheBookSpot.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Books.ToList();
            return View();
        }
    }
}
