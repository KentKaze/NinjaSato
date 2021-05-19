using System;
using System.Collections.Generic;
using System.Text;

namespace ArinaWorld
{
    public class Item
    {
        public long PrototypeID { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public long Durable { get; set; }
        public long Quantity { get; set; }
    }
}
