using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public class CalamityWeaponChecklist : Mod
    {
        public static List<WeaponInfo> calamityWeapons;

        public static Dictionary<string, WeaponInfo> calamityWeaponLookup;

        public static HashSet<string> calamityWeaponNames;

        public override void Load()
        {
        }

        public override void Unload()
        {
            calamityWeapons = null;
            calamityWeaponLookup = null;
            calamityWeaponNames = null;
        }

        public override void PostSetupContent()
        {
            calamityWeapons = new List<WeaponInfo>();

            calamityWeaponLookup = new Dictionary<string, WeaponInfo>();

            calamityWeaponNames = new HashSet<string>();

            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                var allItems = calamityMod.GetContent<ModItem>().ToList();

                var weaponItems = allItems
                    .Where(mi =>
                    {
                        string full = mi.GetType().FullName ?? "";
                        return full.StartsWith("CalamityMod.Items.Weapons.");
                    })
                    .ToList();

                foreach (var mi in weaponItems)
                {
                    string internalName = mi.Name;

                    string name =
                        mi.DisplayName?.Value
                        ?? mi.Name
                        ?? mi.GetType().Name;

                    string category = GetCategoryFromNamespace(mi);

                    var info = new WeaponInfo(
                        mi.Type,
                        internalName,
                        name,
                        category
                    );

                    if (WeaponBossMappings.Mapping.TryGetValue(
                        internalName,
                        out List<List<int>> bossRequirements))
                    {
                        info.DependentBosses = bossRequirements;
                    }

                    calamityWeapons.Add(info);

                    calamityWeaponLookup[internalName] = info;

                    calamityWeaponNames.Add(internalName);
                }

                // Missing mappings
                foreach (var info in calamityWeapons)
                {
                    if (!WeaponBossMappings.Mapping.ContainsKey(info.InternalName))
                    {
                        Logger.Warn($"[Checklist] Missing boss mapping for: {info.Name} ({info.InternalName})");
                    }
                }

                // Removed weapons
                foreach (var mappedName in WeaponBossMappings.Mapping.Keys)
                {
                    if (!calamityWeaponNames.Contains(mappedName))
                    {
                        Logger.Warn($"[Checklist] Mapping exists for removed weapon: {mappedName}");
                    }
                }
            }
        }

        private string GetCategoryFromNamespace(ModItem modItem)
        {
            string full = modItem.GetType().FullName ?? "";
            string[] parts = full.Split('.');

            if (parts.Length >= 4)
                return parts[3];

            return "Unknown";
        }
    }
}