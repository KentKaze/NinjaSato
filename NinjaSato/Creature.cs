using System;
using System.Collections.Generic;
using System.Text;

namespace ArinaWorld
{
    public class Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public int PrototypeID { get; set; }
        public int Hitpoint { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Appearance { get; set; }
    }
}
