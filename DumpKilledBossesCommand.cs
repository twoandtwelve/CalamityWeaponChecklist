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

        public override string Description => "Dumps all Calamity weapons and their mapping state to a text file.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (CalamityWeaponChecklist.calamityWeapons == null ||
                CalamityWeaponChecklist.calamityWeapons.Count == 0)
            {
                Main.NewText("No weapons loaded. Is Calamity loaded?");
                return;
            }

            string path = Path.Combine(Main.SavePath, "CalamityWeaponMapping.txt");

            List<string> lines = new List<string>();

            lines.Add("// Format: { itemType, bossType }, // Weapon Name");
            lines.Add("");

            foreach (var weapon in CalamityWeaponChecklist.calamityWeapons
                         .OrderBy(w => w.Name))
            {
                int boss = weapon.DependentBossType;
                lines.Add($"{{ {weapon.Type}, {boss} }}, // {weapon.Name}");
            }

            File.WriteAllLines(path, lines);

            Main.NewText($"Weapon mapping written to: {path}");
        }
    }
}