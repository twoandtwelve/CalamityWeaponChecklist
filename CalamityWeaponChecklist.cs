using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;


namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklist : Mod
    {
        public static List<ModItem> calamityWeapons;

        public override void PostSetupContent()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                calamityWeapons = calamityMod.GetContent<ModItem>().ToList();
                foreach (var weapon in calamityWeapons)
                {
                    Logger.Info($"Item: " + weapon);
                }
            }
        }
    }
}