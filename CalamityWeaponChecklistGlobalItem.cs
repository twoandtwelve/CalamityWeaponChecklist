using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklistGlobalItem : GlobalItem
    {
        public override void OnCreated(Item item, ItemCreationContext context)
        {
            // Only care about items crafted via recipes, and only on the client
            if (context is RecipeItemCreationContext && !Main.dedServ)
            {
                var player = Main.LocalPlayer;
                if (player != null)
                {
                    player.GetModPlayer<CalamityWeaponChecklistPlayer>()
                          .AddItemToList(item);
                }
            }
        }

        public override bool OnPickup(Item item, Player player)
        {
            // Only run for the local player on client
            if (!Main.dedServ && player.whoAmI == Main.myPlayer)
            {
                player.GetModPlayer<CalamityWeaponChecklistPlayer>()
                      .AddItemToList(item);
            }

            return true; // allow normal pickup behaviour
        }
    }
}
