using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CalamityWeaponChecklist
{
    public class DumpWeaponMappingCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;
        public override string Command => "dumpweapons";
        public override string Usage => "/dumpweapons";
        public override string Description => "Dumps all weapons with internal names and boss mappings.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (CalamityWeaponChecklist.calamityWeapons == null ||
                CalamityWeaponChecklist.calamityWeapons.Count == 0)
            {
                Main.NewText("No weapons loaded.");
                return;
            }

            string path = Path.Combine(Main.SavePath, "CalamityWeaponMapping.txt");
            List<string> lines = new();

            lines.Add("// Format: InternalItemName => BossGroups (AND = & , OR = |)");
            lines.Add("");

            foreach (var weapon in CalamityWeaponChecklist.calamityWeapons
                         .OrderBy(w => w.Name))
            {
                string internalName = weapon.InternalName;

                string bossString;

                if (weapon.DependentBosses == null || weapon.DependentBosses.Count == 0)
                {
                    bossString = "NONE";
                }
                else
                {
                    bossString = string.Join("|",
                        weapon.DependentBosses.Select(group =>
                            string.Join("&", group)));
                }

                lines.Add($"{internalName} => {bossString}");
            }

            File.WriteAllLines(path, lines);
            Main.NewText($"Weapon mapping written to: {path}");
        }
    }
}