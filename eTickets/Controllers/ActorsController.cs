using eTickets.Data;
using eTickets.Data.Infrastructure.Abstract;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private  IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAllActors();
            return View(data);
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.AddActor(actor);
            return RedirectToAction(nameof(Index));     
        }

        public async Task<IActionResult> Details(int id)
        {
            var actor = _actorsService.GetActorById(id);
            if(actor == null)
            {
                return View("Empty");
            }

            return View(actor);
        }
    }
}
