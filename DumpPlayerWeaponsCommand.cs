using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CalamityWeaponChecklist
{
    public class DumpPlayerWeaponsCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;
        public override string Command => "dumpplayerweapons";
        public override string Usage => "/dumpplayerweapons";
        public override string Description => "Dumps all Calamity weapons tracked in the player's save data.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            var player = Main.LocalPlayer;

            if (player == null)
            {
                Main.NewText("No local player found.");
                return;
            }

            var modPlayer = player.GetModPlayer<CalamityWeaponChecklistPlayer>();

            if (modPlayer == null || modPlayer.checklist == null || modPlayer.checklist.Count == 0)
            {
                Main.NewText("No tracked weapons found in player data.");
                return;
            }

            string path = Path.Combine(Main.SavePath, "PlayerWeaponChecklist.txt");

            List<string> lines = new();

            lines.Add("=== PLAYER CALAMITY WEAPON CHECKLIST ===");
            lines.Add("");

            foreach (string internalName in modPlayer.checklist.OrderBy(x => x))
            {
                // Try resolve back to weapon info
                if (CalamityWeaponChecklist.calamityWeaponLookup != null &&
                    CalamityWeaponChecklist.calamityWeaponLookup.TryGetValue(internalName, out var info))
                {
                    lines.Add($"{info.Name} ({info.Category})");
                    lines.Add($"Internal: {internalName}");
                    lines.Add($"Item ID: {info.Type}");
                }
                else
                {
                    lines.Add($"UNKNOWN WEAPON");
                    lines.Add($"Internal: {internalName}");
                }

                lines.Add("");
            }

            File.WriteAllLines(path, lines);

            Main.NewText($"Player weapon checklist written to: {path}");
        }
    }
}