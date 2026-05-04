using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using Microsoft.Xna.Framework;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklist : Mod
    {
        public static List<WeaponInfo> calamityWeapons;
        public static Dictionary<int, WeaponInfo> calamityWeaponLookup;
        public static HashSet<int> calamityWeaponTypes;


        public override void Load()
        {
        }



        public override void Unload()
        {

            calamityWeapons = null;
            calamityWeaponLookup = null;
            calamityWeaponTypes = null;
        }

        public override void PostSetupContent()
        {
            calamityWeapons = new List<WeaponInfo>();
            calamityWeaponLookup = new Dictionary<int, WeaponInfo>();
            calamityWeaponTypes = new HashSet<int>();

            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                // Get all ModItems from CalamityMod
                var allItems = calamityMod.GetContent<ModItem>().ToList();

                // Filter to items under CalamityMod.Items.Weapons.*
                var weaponItems = allItems
                    .Where(mi =>
                    {
                        string full = mi.GetType().FullName ?? "";
                        return full.StartsWith("CalamityMod.Items.Weapons.");
                    })
                    .ToList();

                foreach (var mi in weaponItems)
                {
                    // Get weapon's proper name
                    string name =
                        mi.DisplayName?.Value
                        ?? mi.Name
                        ?? mi.GetType().Name;

                    // Extract category from namespace
                    string category = GetCategoryFromNamespace(mi);

                    var info = new WeaponInfo(mi.Type, name, category);

                    if (WeaponBossMappings.Mapping.TryGetValue(mi.Type, out List<List<int>> bossRequirements))
                    {
                        info.DependentBosses = bossRequirements;
                    }

                    // Store in collections
                    calamityWeapons.Add(info);
                    calamityWeaponLookup[mi.Type] = info;
                    calamityWeaponTypes.Add(mi.Type);
                }

                foreach (var info in calamityWeapons)
                {
                    if (!WeaponBossMappings.Mapping.ContainsKey(info.Type))
                    {
                        Logger.Warn($"[Checklist] Missing boss mapping for: {info.Name} ({info.Type})");
                    }
                }

                foreach (var mappedType in WeaponBossMappings.Mapping.Keys)
                {
                    if (!calamityWeaponTypes.Contains(mappedType))
                    {
                        Logger.Warn($"[Checklist] Mapping exists for removed weapon type: {mappedType}");
                    }
                }
            }
        }

        private string GetCategoryFromNamespace(ModItem modItem)
        {
            string full = modItem.GetType().FullName ?? "";
            string[] parts = full.Split('.');

            if (parts.Length >= 4)
                return parts[3]; // Melee, Magic, Ranged, Summon, Rogue, etc.

            return "Unknown";
        }
    }
}
