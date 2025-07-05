using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AddDbContext _context;

        public ActorsController(AddDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();        //fetch all actors from the database and storing it to data variable
            return View();
        }
    }
}
