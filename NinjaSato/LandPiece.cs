using System;
using System.Collections.Generic;
using System.Text;

namespace ArinaWorld
{
    public class LandPiece
    {        
        public long ID { get; set; }
        
        public string Terrain { get; set;}
        
        public long Altitude { get; set; }
   
        public MapPosition Position { get; set; }

        public string NaturalDevelopment { get; set; }

        public List<Item> Resources { get; set; }

        public long GroundWater { get; set; }

        public List<Construct> Construct { get; set; }

        //Improvement


    }
}
