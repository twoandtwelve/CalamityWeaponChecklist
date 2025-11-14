using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistPlayer : ModPlayer
    {
        // Track only item.type values for weapons acquired
        public HashSet<int> checklist = new HashSet<int>();

        public void AddItemToList(Item item)
        {
            int type = item.type;

            // Only track Calamity weapons
            if (!CalamityWeaponChecklist.calamityWeaponTypes.Contains(type))
                return;

            // Add silently to the HashSet
            checklist.Add(type);
        }

        public override void PreUpdate()
        {
            InventoryScan();
        }

        public override void UpdateAutopause()
        {
            InventoryScan();
        }

        private void InventoryScan()
        {
            if (Main.dedServ || Player.whoAmI != Main.myPlayer)
                return;

            // Scan main inventory slots 0–58
            for (int i = 0; i < 59; i++)
            {
                Item invItem = Player.inventory[i];

                if (invItem.IsAir)
                    continue;

                int type = invItem.type;

                // Only count Calamity weapons
                if (!CalamityWeaponChecklist.calamityWeaponTypes.Contains(type))
                    continue;

                checklist.Add(type);

            }
        }

        // Save HashSet<int>
        public override void SaveData(TagCompound tag)
        {
            tag["CalamityWeaponChecklist"] = new List<int>(checklist);
        }

        // Load HashSet<int>
        public override void LoadData(TagCompound tag)
        {
            var list = tag.Get<List<int>>("CalamityWeaponChecklist");
            checklist = new HashSet<int>(list);
        }
    }
}
