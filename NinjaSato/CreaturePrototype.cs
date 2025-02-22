﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArinaWorld
{
    public class CreaturePrototype
    {
        //25~100
        public int ID { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public char Sex { get; set; }
        public int Hitpoint { get; set; }        
        public int BaseStrength { get; set; }
        public int StrengthVaryRange { get; set; }
        public int BaseDexterity { get; set; }
        public int DexterityVaryRange { get; set; }
        public int BaseIntelligence { get; set; }
        public int IntelligenceVaryRange { get; set; }
        public int BaseAppearance { get; set; }
        public int AppearanceVaryRange { get; set; }
    }
}
