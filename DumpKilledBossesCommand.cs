using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public class DumpKilledBossesCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;
        public override string Command => "dumpkilledbosses";
        public override string Usage => "/dumpkilledbosses";
        public override string Description => "Dumps all killed bosses in the current world.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            var killed = BossTracker.DefeatedBossTypes;

            if (killed == null || killed.Count == 0)
            {
                Main.NewText("No bosses recorded yet.");
                return;
            }

            string path = Path.Combine(Main.SavePath, "KilledBossesDump.txt");
            List<string> lines = new();

            lines.Add("=== KILLED BOSSES ===\n");

            foreach (int bossType in killed.OrderBy(x => x))
            {
                string name = "Unknown Boss";
                string mod = "UnknownMod";

                if (ContentSamples.NpcsByNetId.TryGetValue(bossType, out NPC npc) && npc != null)
                {
                    name = npc.FullName;
                    mod = npc.ModNPC?.Mod?.Name ?? "Terraria";
                }

                lines.Add($"{bossType}: {mod}/{name}");
            }

            File.WriteAllLines(path, lines);
            Main.NewText($"Killed bosses dumped to: {path}");
        }
    }
}