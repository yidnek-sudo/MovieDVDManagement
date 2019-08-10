using DVDManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.ViewModel
{
    public class CustomerViewModel
    {
        public Client Client { get; set; }
        public int DvdCount { get; set; }
    }
}

