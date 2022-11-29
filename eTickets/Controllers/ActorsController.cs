using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private AppDbContext _dbContext;

        public ActorsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public async Task<IActionResult> Index()
        {
            var data = await _dbContext.Actors.ToListAsync();
            return View(data);
        }
    }
}
