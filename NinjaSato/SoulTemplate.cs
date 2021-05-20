using System;
using System.Collections.Generic;
using System.Text;

namespace ArinaWorld
{
    public class SoulTemplate
    {
        public int ID { get; set; }
        public int BaseLevel { get; set; }
        public int LevelVaryRange { get; set; }
        public string SpecificName { get; set; }        
        public bool RandomName { get; set; }
        public int BaseAlignment { get; set; }
        public int AlignmentVaryRange { get; set; }
        public int BaseSense { get; set; }
        public int SenseVaryRange { get; set; }
        public int BaseWill { get; set; }
        public int WillVaryRange { get; set; }
        public int BaseManaPoint { get; set; }
        public int BaseSkillPoint { get; set; }
    }
}
