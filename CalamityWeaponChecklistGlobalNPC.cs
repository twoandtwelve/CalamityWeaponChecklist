using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            // Only consider bosses
            if (!npc.boss)
                return;

            // Optional: skip weird cases/statue spawns if you care
            if (npc.SpawnedFromStatue)
                return;

            int npcType = GetCanonicalBossType(npc.type);

            CalamityWeaponChecklistSystem.DefeatedBossTypes.Add(npcType);
        }

        private int GetCanonicalBossType(int type)
        {
            // === VANILLA MULTI-PART BOSSES ===

            // Moon Lord (head, hands, core) -> 396
            if (type == 396 || type == 397 || type == 398)
                return 396;

            // The Twins (Retinazer + Spazmatism) -> 125
            if (type == 125 || type == 126)
                return 125;

            // === CALAMITY MULTI-PART BOSSES ===

            // Astrum Deus -> 758
            if (type == 758 || type == 759 || type == 760)
                return 758;

            // Desert Scourge -> 789
            if (type == 789 || type == 790 || type == 791)
                return 789;

            // Devourer of Gods -> 795
            if (type == 795 || type == 796 || type == 797)
                return 795;


            // === EXO MECHS (Apollo, Ares, Artemis, Thanatos) ===
            // All mapped to 804 (Apollo)
            if (type == 804 ||     // Apollo
                type == 805 ||     // Ares
                type == 806 ||     // Ares Gauss Nuke
                type == 807 ||     // Ares Laser Cannon
                type == 808 ||     // Ares Plasma Cannon
                type == 809 ||     // Ares Tesla Cannon
                type == 810 ||     // Artemis
                type == 812 ||     // Thanatos
                type == 813 ||
                type == 814 ||
                type == 815)
            {
                return 804;
            }

            // === STORM WEAVER (multi-segment) ===
            if (type == 951 || type == 952 || type == 953)
                return 951;

            // Default: treat this NPC type itself as the canonical boss
            return type;
        }

    }
}
