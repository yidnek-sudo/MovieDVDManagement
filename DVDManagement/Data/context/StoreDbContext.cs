using DVDManagement.Data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.context
{
    public class StoreDbContext:DbContext
    {

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Dvd> Dvds { get; set; }
    }



}
