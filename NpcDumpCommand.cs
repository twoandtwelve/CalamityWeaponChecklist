using System.IO;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace YourModName.Commands
{
    public class NpcDumpCommand : ModCommand
    {
        public override CommandType Type => CommandType.Chat;

        public override string Command => "dumpnpcs";

        public override string Usage => "/dumpnpcs";

        public override string Description => "Dumps all registered ModNPC internal names to a text file.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=== REGISTERED MOD NPCs ===");

            foreach (var npc in ModContent.GetContent<ModNPC>())
            {
                sb.AppendLine($"{npc.FullName} | Type: {npc.Type}");
            }

            string path = Path.Combine(Main.SavePath, "npc_dump.txt");
            File.WriteAllText(path, sb.ToString());

            Main.NewText($"NPC dump saved to: {path}", 50, 255, 130);
        }
    }
}