using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.ViewModel
{
    public class LendViewModel
    {
        public Dvd Dvd { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
