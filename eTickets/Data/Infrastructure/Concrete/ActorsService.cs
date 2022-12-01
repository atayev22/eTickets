using eTickets.Data.Infrastructure.Abstract;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Infrastructure.Concrete
{
    public class ActorsService : IActorsService
    {
        private AppDbContext _dbContext;

        public ActorsService(AppDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public async Task AddActor(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            await _dbContext.SaveChangesAsync();
        }

        public void DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActorById(int id)
        {
            var result = await _dbContext.Actors.FirstOrDefaultAsync(a => a.Id == id);
            return result;
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var result = await _dbContext.Actors.ToListAsync();
            return result;
        }

        public Actor UpdateActor(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
