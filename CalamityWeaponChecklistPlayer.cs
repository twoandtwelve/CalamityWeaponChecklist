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

        public override void UpdateAutopause()
        {
            ChestCheck();
        }


        public override void PreUpdate()
        {
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

            // Check chest contents if a chest is open
            if (Player.chest != -1 &&
                (Player.chest != Player.lastChest || (Main.autoPause && Main.gamePaused)) &&
                findChestItemsPreference)
            {
                Item[] items;
                // Determine which chest to check
                if (Player.chest == -2)
                    items = Player.bank.item; // Piggy Bank
                else if (Player.chest == -3)
                    items = Player.bank2.item; // Safe
                else if (Player.chest == -4)
                    items = Player.bank3.item; // Defender's Forge
                else if (Player.chest == -5)
                    items = Player.bank4.item; // Void Vault
                else
                    items = Main.chest[Player.chest].item; // Regular chest

                // Check each item in the chest
                for (int i = 0; i < 40; i++) // 40 is the max number of slots in a chest
                {
                    if (!items[i].IsAir &&
                        !checklist.Any(x => x.type == items[i].type) &&
                        CalamityWeaponChecklist.calamityWeapons.Any(w => w.Type == items[i].type))
                    {
                        AddItemToList(items[i]);
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