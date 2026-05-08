using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;
using System.Linq;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistPlayer : ModPlayer
    {
        public HashSet<string> checklist = new();

        public void AddItemToList(Item item)
        {
            ModItem modItem = ItemLoader.GetItem(item.type);

            if (modItem == null)
                return;

            string internalName = modItem.Name;

            if (!CalamityWeaponChecklist.calamityWeaponNames.Contains(internalName))
                return;

            checklist.Add(internalName);
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

            for (int i = 0; i < 59; i++)
            {
                Item invItem = Player.inventory[i];

                if (invItem.IsAir)
                    continue;

                ModItem modItem = ItemLoader.GetItem(invItem.type);

                if (modItem == null)
                    continue;

                string internalName = modItem.Name;

                if (!CalamityWeaponChecklist.calamityWeaponNames.Contains(internalName))
                    continue;

                checklist.Add(internalName);
            }
        }

        public override void SaveData(TagCompound tag)
        {
            tag["CalamityWeaponChecklist"] = checklist.ToList();
        }

        public override void LoadData(TagCompound tag)
        {
            if (tag.ContainsKey("CalamityWeaponChecklist"))
            {
                var list = tag.Get<List<string>>("CalamityWeaponChecklist");

                checklist = new HashSet<string>(list);
            }
            else
            {
                checklist = new HashSet<string>();
            }
        }
    }
}