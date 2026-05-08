using System.Collections.Generic;

namespace CalamityWeaponChecklist
{
    public class WeaponInfo
    {
        public int Type { get; }

        public string InternalName { get; }

        public string Name { get; }
        public string Category { get; }

        public List<List<int>> DependentBosses { get; set; }

        public WeaponInfo(int type, string internalName, string name, string category)
        {
            Type = type;
            InternalName = internalName;
            Name = name;
            Category = category;

            DependentBosses = new List<List<int>>
            {
                new List<int> { -1 }
            };
        }

        public override string ToString()
        {
            return $"{Name} ({InternalName}) ({Category}) - Type {Type}, Bosses: {FormatBosses()}";
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