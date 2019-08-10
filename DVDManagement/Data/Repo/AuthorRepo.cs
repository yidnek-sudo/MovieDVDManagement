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
    public class AuthorRepo : Repo<Author>, IAuthorRepo
    {
        public AuthorRepo(StoreDbContext context) : base(context)
        {

        }

        public IEnumerable<Author> GetAllWithBooks()
        {
            return _context.Authors.Include(a => a.Dvds);
        }

        public Author GetWithBooks(int id)
        {
            return _context.Authors
                .Where(a => a.AuthorId == id)
                .Include(a => a.Dvds)
                .FirstOrDefault();
        }
    }
}