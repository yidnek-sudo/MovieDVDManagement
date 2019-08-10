using DVDManagement.Data.context;
using DVDManagement.Data.InterfaceRepo;
using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.Repo
{
    public class ClientRepo: Repo<Client>, IClientRepo
    {
        public ClientRepo(StoreDbContext context) : base(context)
       {
         }
    }
 }
