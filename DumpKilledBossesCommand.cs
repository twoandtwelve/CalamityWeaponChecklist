using System;
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

            lines.Add("=== KILLED BOSSES ===");
            lines.Add("");

            foreach (int bossType in killed.OrderBy(x => x))
            {
                string name = GetBossNameFromNPC(bossType);
                string mod = GetModName(bossType);

                lines.Add($"{bossType}: {mod}/{name}");
            }

            File.WriteAllLines(path, lines);

            Main.NewText($"Killed bosses dumped to: {path}");
        }

        private string GetBossNameFromNPC(int type)
        {
            if (ContentSamples.NpcsByNetId.TryGetValue(type, out NPC npc) && npc != null)
            {
                return npc.FullName;
            }

            return "Unknown Boss";
        }

        private string GetModName(int type)
        {
            if (ContentSamples.NpcsByNetId.TryGetValue(type, out NPC npc) && npc != null)
            {
                return npc.ModNPC?.Mod?.Name ?? "Terraria";
            }

            return "UnknownMod";
        }
    }
}