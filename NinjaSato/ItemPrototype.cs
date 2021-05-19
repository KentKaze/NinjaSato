using System;
using System.Collections.Generic;
using System.Text;

namespace ArinaWorld
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryList
    {
        None,
        Food,
        Livingware,
        Tool,
        Device,
        Equipment,  
        Material
    }

    //[JsonConverter(typeof(StringEnumConverter))]
    public enum SubtypeList
    {
        Fruit,
        Resource,
        Weapon,
        Shield,
        Armor
    }

    public class ItemPrototype
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public CategoryList Category { get; set; }
        public List<SubtypeList> Subtype { get; set; }
        public long DurableMax { get; set; } = 100;
        public long Value { get; set; }

    }
}
