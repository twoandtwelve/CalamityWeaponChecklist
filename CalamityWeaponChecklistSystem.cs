using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;
using System.Linq;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistSystem : ModSystem
    {
        public static HashSet<int> DefeatedBossTypes = new HashSet<int>();

        public override void OnWorldLoad()
        {
            DefeatedBossTypes.Clear();
        }

        public override void OnWorldUnload()
        {
            DefeatedBossTypes.Clear();
        }

        public override void SaveWorldData(TagCompound tag)
        {
            tag["DefeatedBossTypes"] = DefeatedBossTypes.ToList();
        }

        public override void LoadWorldData(TagCompound tag)
        {
            if (tag.ContainsKey("DefeatedBossTypes"))
            {
                var list = tag.Get<List<int>>("DefeatedBossTypes");
                DefeatedBossTypes = new HashSet<int>(list);
            }
            else
            {
                DefeatedBossTypes = new HashSet<int>();
            }
        }
    }
}
