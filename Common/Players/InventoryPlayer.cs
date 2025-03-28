using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.Collections.Generic;
using System.Linq;

namespace CalamityWeaponChecklist.Common.Players
{
	public class InventoryPlayer : ModPlayer
	{
		public IList<string> checklist;

		public override bool OnPickup(Item item)
		{
			Main.NewText(Player.name + " picked up " + item.Name, 0, 255, 255);

			if (!checklist.Contains(item.Name))
			{
				checklist.Add(item.Name);
			} 

			return true;
		}

		public override void SaveData(TagCompound tag)
		{
			tag["CalamityWeaponChecklist"] = checklist;
		}

		public override void LoadData(TagCompound tag)
		{
			if (!tag.ContainsKey("CalamityWeaponChecklist"))
			{
				tag.Add("CalamityWeaponChecklist", new List<string>());
			}
			else
			{
				checklist = tag.GetList<string>("CalamityWeaponChecklist");
			}
		}

		public override void OnEnterWorld()
		{

		}

	}
}