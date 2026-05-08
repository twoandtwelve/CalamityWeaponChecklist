using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.IO;

namespace CalamityWeaponChecklist
{
    public class DumpBossesCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;
        public override string Command => "dumpbosses";
        public override string Usage => "/dumpbosses";
        public override string Description => "Dumps all boss NPC types and names to a text file.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            string path = Path.Combine(Main.SavePath, "BossList.txt");
            List<string> lines = new();

            foreach (var kvp in ContentSamples.NpcsByNetId)
            {
                NPC npc = kvp.Value;
                if (npc == null) continue;

                bool isBoss =
                    npc.boss ||
                    (kvp.Key >= 0 &&
                     kvp.Key < NPCID.Sets.ShouldBeCountedAsBoss.Length &&
                     NPCID.Sets.ShouldBeCountedAsBoss[kvp.Key]);

                if (!isBoss)
                    continue;

                string modName = npc.ModNPC?.Mod?.Name ?? "Terraria";
                lines.Add($"{kvp.Key}: {modName}/{npc.FullName}");
            }

            File.WriteAllLines(path, lines);
            Main.NewText($"Boss list written to: {path}");
        }
    }
}