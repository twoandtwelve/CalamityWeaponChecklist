using System.Collections.Generic;
using Terraria;

namespace CalamityWeaponChecklist
{
    public class WeaponInfo
    {
        public int Type { get; }
        public string Name { get; }
        public string Category { get; }

        public List<List<int>> DependentBosses { get; set; }

        public WeaponInfo(int type, string name, string category)
        {
            Type = type;
            Name = name;
            Category = category;

            // default = no dependency / pre-boss
            DependentBosses = new List<List<int>>
            {
                new List<int> { -1 }
            };
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - Type {Type}, Bosses: {FormatBosses()}";
        }

        private string FormatBosses()
        {
            if (DependentBosses == null)
                return "null";

            return string.Join(" OR ",
                DependentBosses.ConvertAll(group =>
                    "[" + string.Join(", ", group) + "]"));
        }
    }
}