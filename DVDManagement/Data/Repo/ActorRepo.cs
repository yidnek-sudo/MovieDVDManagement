using DVDManagement.Data.context; 
using DVDManagement.Data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVDManagement.Data.InterfaceRepo;
namespace DVDManagement.Data.Repo
{
    public class ActorRepo : Repo<Actor>, IActorRepo
    {
        public ActorRepo(StoreDbContext context) : base(context)
        {

        }

        public IEnumerable<Actor> GetAllWithDvds()
        {
            return _context.Actors.Include(a => a.Dvds);
        }

        public Actor GetWithDvds(int id)
        {
            return _context.Actors
                .Where(a => a.ActorId == id)
                .Include(a => a.Dvds)
                .FirstOrDefault();
        }
    }
}