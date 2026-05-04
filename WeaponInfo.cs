using Terraria;

namespace CalamityWeaponChecklist
{
    public class WeaponInfo
    {
        public int Type { get; }
        public string Name { get; }
        public string Category { get; }
        public int DependentBossType { get; set; }

        public WeaponInfo(int type, string name, string category)
        {
            Type = type;
            Name = name;
            Category = category;
            DependentBossType = -1;
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - Type {Type}, BossType: {DependentBossType}";
        }
    }
}