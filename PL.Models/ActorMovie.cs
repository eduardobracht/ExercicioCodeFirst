using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class ActorMovie
    {
        public int ID { get; set; }
        public int ActorID { get; set; }
        public int MovieID { get; set; }
        public string Role { get; set; }
    }
}
