using System.Linq;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public static class DumpWeaponmapping
    {
        public static void Dump()
        {
            var mod = ModContent.GetInstance<CalamityWeaponChecklist>();

            if (CalamityWeaponChecklist.calamityWeapons == null ||
                CalamityWeaponChecklist.calamityWeapons.Count == 0)
            {
                mod.Logger.Warn("[Checklist] No weapons loaded. Cannot dump mapping template.");
                return;
            }

            mod.Logger.Info("----- Weapon Mapping Template Start -----");

            foreach (var weapon in CalamityWeaponChecklist.calamityWeapons
                         .OrderBy(w => w.Name))
            {
                mod.Logger.Info($"{{ {weapon.Type}, -1 }}, // {weapon.Name}");
            }

            mod.Logger.Info("----- Weapon Mapping Template End -----");
        }
    }
}