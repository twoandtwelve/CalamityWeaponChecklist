using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent; // for ContentSamples
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.ID;

namespace CalamityWeaponChecklist
{
    public class DumpKilledBossesCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;

        public override string Command => "dumpkilledbosses";

        public override string Usage => "/dumpkilledbosses";

        public override string Description => "Dumps this world's killed bosses (canonical types) to a text file.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            // Main.SavePath is usually: Documents/My Games/Terraria/tModLoader
            string path = Path.Combine(Main.SavePath, "WorldBossesKilled.txt");

            var defeated = CalamityWeaponChecklistSystem.DefeatedBossTypes;

            List<string> lines = new List<string>();

            if (defeated == null || defeated.Count == 0)
            {
                lines.Add("No bosses have been recorded as defeated in this world yet.");
            }
            else
            {
                foreach (int type in defeated.OrderBy(t => t))
                {
                    string line;

                    if (ContentSamples.NpcsByNetId.TryGetValue(type, out NPC npc) && npc != null)
                    {
                        string modName = npc.ModNPC?.Mod?.Name ?? "Terraria";
                        string name = npc.FullName;
                        line = $"{type}: {modName}/{name}";
                    }
                    else
                    {
                        line = $"{type}: <unknown NPC>";
                    }

                    lines.Add(line);
                }
            }

            File.WriteAllLines(path, lines);

            Main.NewText($"World boss kill data written to: {path}");
        }
    }
}
