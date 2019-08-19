using DVDManagement.Data.context;
using DVDManagement.Data.InterfaceRepo;
using DVDManagement.Data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.Repo
{
    public class DvdRepo : Repo<Dvd>, IDvdRepo
    {
        public DvdRepo(StoreDbContext context) : base(context)
        {
        }

        public IEnumerable<Dvd> FindWithActor(Func<Dvd, bool> predicate)
        {
            return _context.Dvds
                .Include(a => a.Actor)
                .Where(predicate);
        }

        public IEnumerable<Dvd> FindWithActorAndClient(Func<Dvd, bool> predicate)
        {
            return _context.Dvds
                .Include(a => a.Actor)
                .Include(a => a.Client)
                .Where(predicate);
        } 
        public IEnumerable<Dvd> GetAllWithActor()
        {
            return _context.Dvds.Include(a => a.Actor);
        }
    }
}