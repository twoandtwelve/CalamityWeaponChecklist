using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CalamityWeaponChecklist
{
    public class DumpAllWeaponsCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;
        public override string Command => "dumpallweapons";
        public override string Usage => "/dumpallweapons";
        public override string Description => "Dumps all Calamity weapons using internal ModItem names.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            string path = Path.Combine(Main.SavePath, "AllWeaponsDump.txt");
            List<string> lines = new();

            lines.Add("=== WEAPON DUMP (MODITEM INTERNAL NAME SYSTEM) ===");
            lines.Add("");

            foreach (var weapon in CalamityWeaponChecklist.calamityWeapons
                         .OrderBy(w => w.Name))
            {
                lines.Add($"Name: {weapon.Name}");
                lines.Add($"Internal Name: {weapon.InternalName}");
                lines.Add($"Item ID: {weapon.Type}");
                lines.Add("");
            }

            File.WriteAllLines(path, lines);

            Main.NewText($"Weapon dump written to: {path}");
        }
    }
}