using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.InterfaceRepo
{
   public interface IActorRepo : IRepo<Actor>
    {
        IEnumerable<Actor> GetAllWithDvds();
        Actor GetWithDvds(int id);
    }
}
