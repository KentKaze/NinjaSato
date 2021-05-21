using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWorld
{
    public class LivingThingTemplate
    {
        public int ID { get; set; }
        public int CreaturePrototypeID { get; set; }
        public string SpecificSurname { get; set; }
        public string SpecificName { get; set; }
        public List<string> RandomNames { get; set; }
        public string RandomName { get; set; }
        public int SoulTemplateID { get; set; }
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
