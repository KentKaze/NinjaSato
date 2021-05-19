using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWorld
{
    public class ActivityPrototype
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long MinimizeParticipant { get; set; }
        public long MaximizeParticipant { get; set; }
        public List<long> ParticipantChoose { get; set; }
        public long MinimizeDuration { get; set; }
        public long MaximizeDuration { get; set; }
        public List<long> DurationChoose { get; set; }
        public long EXP { get; set; }
    }
}
