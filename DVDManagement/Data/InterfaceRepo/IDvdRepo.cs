using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.InterfaceRepo
{
    interface IDvdRepo : IRepo<Dvd>
    {
        IEnumerable<Dvd> GetAllWithAuthor();
        IEnumerable<Dvd> FindWithAuthor(Func<Dvd, bool> predicate);
        IEnumerable<Dvd> FindWithAuthorAndBorrower(Func<Dvd, bool> predicate);
    }
}
