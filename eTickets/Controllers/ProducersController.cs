using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private AppDbContext _dbContext;

        public ProducersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult>  Index()
        {
            var data = await _dbContext.Producers.ToListAsync();
            return View();
        }
    }
}
