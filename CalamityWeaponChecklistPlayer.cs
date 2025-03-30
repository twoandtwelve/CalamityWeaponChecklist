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

        public void UpdateChecklist(Item item)
        {
            if (checklist.Any(x => x.Name == item.Name))
            {
                Main.NewText(Player.name + " already has " + item);
                Main.NewText(Player.name + " list size is STILL " + checklist.Count);
            }
            else
            {
                checklist.Add(item);
                Main.NewText(Player.name + " acquired " + item);
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
            checklist = tag.GetList<Item>("CalamityWeaponChecklist");
        }

        public override void OnEnterWorld()
        {
            Main.NewText(Player.name + " initial list size is " + checklist.Count) ;
        }
    }

}