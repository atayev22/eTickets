using eTickets.Models;

namespace eTickets.Data.Infrastructure.Abstract
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Task<Actor> GetActorById(int id);
        Task AddActor(Actor actor);
        Actor UpdateActor(int id, Actor actor);
        void DeleteActor(int id);
    }
}
