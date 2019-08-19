using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.model
{
    public class Dvd
    {

        public int DvdId { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Title { get; set; }

        public virtual Actor Actor{ get; set; }
        public int ActorId { get; set; }

        public virtual Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
