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

        public void AddActor(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            _dbContext.SaveChanges();
        }

        public void DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorById(int id)
        {
            throw new NotImplementedException();
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
