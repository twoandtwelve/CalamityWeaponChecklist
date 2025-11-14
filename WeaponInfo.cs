using Terraria;

namespace CalamityWeaponChecklist
{
    public class WeaponInfo
    {
        public int Type { get; }
        public string Name { get; }
        public string Category { get; }
        public string DependentBoss { get; set; }  // you fill this later

        public WeaponInfo(int type, string name, string category)
        {
            Type = type;
            Name = name;
            Category = category;
            DependentBoss = "None"; // default placeholder
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - Type {Type}, Boss: {DependentBoss}";
        }
    }
}
