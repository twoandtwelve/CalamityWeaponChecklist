using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;



namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistGlobalItem : GlobalItem
    {
        public override void OnCreated(Item item, ItemCreationContext context)
        {
            if (context is RecipeItemCreationContext)
            {
                Main.LocalPlayer.GetModPlayer<CalamityWeaponChecklistPlayer>().AddItemToList(item);
            }
        }

        public override bool OnPickup(Item item, Player player)
        {
            player.GetModPlayer<CalamityWeaponChecklistPlayer>().AddItemToList(item);
            return true;
        }
    }
}