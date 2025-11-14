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
            // This is usually: Documents/My Games/Terraria/tModLoader
            string path = Path.Combine(Main.SavePath, "BossList.txt");

            List<string> lines = new List<string>();

            foreach (var kvp in ContentSamples.NpcsByNetId)
            {
                int type = kvp.Key;
                NPC npc = kvp.Value;

                if (npc == null)
                    continue;

                bool isBoss = false;

                // 1) Direct boss flag (works for vanilla + most modded bosses)
                if (npc.boss)
                    isBoss = true;

                // 2) Vanilla helper flag (ONLY safe for vanilla IDs)
                if (!isBoss && type >= 0 && type < NPCID.Sets.ShouldBeCountedAsBoss.Length)
                {
                    if (NPCID.Sets.ShouldBeCountedAsBoss[type])
                        isBoss = true;
                }

                if (!isBoss)
                    continue;

                string modName = npc.ModNPC?.Mod?.Name ?? "Terraria";
                string name = npc.FullName; // NPC's display name

                lines.Add($"{type}: {modName}/{name}");
            }

            File.WriteAllLines(path, lines);

            Main.NewText($"Boss list written to: {path}");
        }
    }
}
