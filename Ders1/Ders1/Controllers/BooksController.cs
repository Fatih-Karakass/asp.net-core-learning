using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class BooksController : Controller
    {
        private readonly AddDbContext AddDbContext;
        public BooksController(AddDbContext _addDbContext)
        {
            AddDbContext = _addDbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Books> list = AddDbContext.books.ToList();
            return View(list);
        }
    }
}
