using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;
using System.Linq;

namespace CalamityWeaponChecklist.Common.Players
{
    public class InventoryPlayer : ModPlayer
    {
        public IList<string> checklist = new List<string>();

        public void UpdateChecklist(Item item)
        {
            if (checklist.Contains(item.Name))
            {
                Main.NewText(Player.name + " already has " + item.Name);
                Main.NewText(Player.name + " list size is STILL " + checklist.Count);
            }
            else
            {
                checklist.Add(item.Name);
                Main.NewText(Player.name + " acquired " + item.Name);
                Main.NewText(Player.name + " INCREASED list size to " + checklist.Count);
            }
        }

        public override void PostBuyItem(NPC vendor, Item[] shop, Item item)
        {
            UpdateChecklist(item);
        }


        public override bool OnPickup(Item item)
        {
            UpdateChecklist(item);
            return true;
        }




        public override void SaveData(TagCompound tag)
        {
            tag["CalamityWeaponChecklist"] = checklist;
        }

        public override void LoadData(TagCompound tag)
        { 
            checklist = tag.GetList<string>("CalamityWeaponChecklist");
        }

        public override void OnEnterWorld()
        {
            Main.NewText(Player.name + " initial list size is " + checklist.Count) ;
        }
    }

}