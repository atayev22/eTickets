using eTickets.Models;

namespace eTickets.Data.Infrastructure.Abstract
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Actor GetActorById(int id);
        void AddActor(Actor actor);
        Actor UpdateActor(int id, Actor actor);
        void DeleteActor(int id);
    }
}
