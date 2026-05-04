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
            mod.Logger.Info("// Format: { itemType, \"bossGroups\" }");
            mod.Logger.Info("// OR = | , AND = & , -1 = pre-boss");
            mod.Logger.Info("");

            foreach (var weapon in CalamityWeaponChecklist.calamityWeapons
                         .OrderBy(w => w.Name))
            {
                string template;

                if (weapon.DependentBosses == null || weapon.DependentBosses.Count == 0)
                {
                    template = "-1";
                }
                else
                {
                    template = string.Join("|",
                        weapon.DependentBosses.Select(group =>
                            string.Join("&", group)));
                }

                mod.Logger.Info($"{{ {weapon.Type}, \"{template}\" }}, // {weapon.Name}");
            }

            mod.Logger.Info("----- Weapon Mapping Template End -----");
        }
    }
}