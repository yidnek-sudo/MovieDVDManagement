using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data.model
{
    public class Actor
    {

        public int ActorId { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Dvd> Dvds
        {
            get; set;
        }
    }
}
