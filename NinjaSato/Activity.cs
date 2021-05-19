using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWorld
{
    public class Activity
    {
        public long ActivityPrototypeID { get; set; }
        public long Duration { get; set; }
        public long PassedTime { get; set; }
        public List<Soul> Participant { get; set; }
    }
}
