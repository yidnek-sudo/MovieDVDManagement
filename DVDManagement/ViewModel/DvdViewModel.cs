using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.ViewModel
{
    public class DvdViewModel
    {
        public Dvd Dvd { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
}
