using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class ActorMovie
    {
        public int ActorMovieID { get; set; }

        public string Role { get; set; }

        public int ActorID { get; set; }
        public virtual Actor Actor { get; set; }

        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
