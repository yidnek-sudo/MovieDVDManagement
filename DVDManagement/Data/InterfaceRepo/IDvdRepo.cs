using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.InterfaceRepo
{
    public interface IDvdRepo : IRepo<Dvd>
    {
        IEnumerable<Dvd> GetAllWithActor();
        IEnumerable<Dvd> FindWithActor(Func<Dvd, bool> predicate);
        IEnumerable<Dvd> FindWithActorAndClient(Func<Dvd, bool> predicate);
    }
}
