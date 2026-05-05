using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.StormWeaver;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (!npc.boss)
                return;

            int npcType = GetCanonicalBossType(npc.type);

            BossTracker.DefeatedBossTypes.Add(npcType);
        }

        private int GetCanonicalBossType(int type)
        {
            // === VANILLA MULTI-PART BOSSES ===

            // Moon Lord (head, hands, core)
            if (type == 396 || type == 397 || type == 398)
                return NPCID.MoonLordCore;

            // === CALAMITY MULTI-PART BOSSES ===

            // Astrum Deus
            if (type == 758 || type == 759 || type == 760)
                return ModContent.NPCType<AstrumDeusHead>();

            // Desert Scourge
            if (type == 791 || type == 792 || type == 793)
                return ModContent.NPCType<DesertScourgeHead>();

            // Devourer of Gods -> 795
            if (type == 794 || type == 795 || type == 796)
                return ModContent.NPCType<DevourerofGodsHead>();


            // === EXO MECHS (Apollo, Ares, Artemis, Thanatos) ===
            if (type == 803 ||     // Apollo
                type == 804 ||     // Ares
                type == 805 ||     // Ares Gauss Nuke
                type == 806 ||     // Ares Laser Cannon
                type == 807 ||     // Ares Plasma Cannon
                type == 808 ||     // Ares Tesla Cannon
                type == 809 ||     // Artemis
                type == 811 ||     // Thanatos
                type == 812 ||
                type == 813 ||
                type == 814)
            {
                return ModContent.NPCType<Apollo>();
            }

            // === STORM WEAVER (multi-segment) ===
            if (type == 944 || type == 945 || type == 953)
                return ModContent.NPCType<StormWeaverHead>();

            // Default: treat this NPC type itself as the canonical boss
            return type;
        }

    }
}
