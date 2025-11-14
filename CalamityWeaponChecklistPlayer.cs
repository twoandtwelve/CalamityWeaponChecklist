using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;
using System.Linq;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistPlayer : ModPlayer
    {
        public IList<Item> checklist = new List<Item>();
        public bool findChestItemsPreference = true;

        public void AddItemToList(Item item)
        {
            if (checklist.Any(x => x.type == item.type))
            {
                Main.NewText(Player.name + " already has " + item);
            }
            else
            {
                checklist.Add(item);
                Main.NewText(Player.name + " acquired " + item);
            }
        }

        public override void PreUpdate()
        {
            //Main.NewText("PreUpdate tick");
            ChestCheck();
        }

        public override void UpdateAutopause()
        {
            //Main.NewText("UpdateAutopause tick");
            ChestCheck();
        }

        private void ChestCheck()
        {
            if (Main.dedServ || Player.whoAmI != Main.myPlayer)
                return;
            // Check player inventory
            for (int i = 0; i < 59; i++)
            {
                if (!Player.inventory[i].IsAir)
                {
                    // Count how many potential weapons we have in inventory
                    if (CalamityWeaponChecklist.calamityWeapons.Any(w => w.Type == Player.inventory[i].type))
                    {
                        bool alreadyInList = checklist.Any(x => x.type == Player.inventory[i].type);
                        if (!alreadyInList)
                        {
                            AddItemToList(Player.inventory[i]);
                        }
                    }
                }
            }
        }


        public override void SaveData(TagCompound tag)
        {
            tag["CalamityWeaponChecklist"] = checklist.Select(ItemIO.Save).ToList();
        }

        public override void LoadData(TagCompound tag)
        {
            checklist = tag.GetList<TagCompound>("CalamityWeaponChecklist").Select(ItemIO.Load).ToList();
        }

    }

}