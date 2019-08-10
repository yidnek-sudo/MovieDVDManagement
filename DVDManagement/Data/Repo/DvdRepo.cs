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

        public IEnumerable<Dvd> FindWithAuthor(Func<Dvd, bool> predicate)
        {
            return _context.Dvds
                .Include(a => a.Author)
                .Where(predicate);
        }

        public IEnumerable<Dvd> FindWithAuthorAndBorrower(Func<Dvd, bool> predicate)
        {
            return _context.Dvds
                .Include(a => a.Author)
                .Include(a => a.Customer)
                .Where(predicate);
        }

        public IEnumerable<Dvd> GetAllWithAuthor()
        {
            return _context.Dvds.Include(a => a.Author);
        }
    }
}