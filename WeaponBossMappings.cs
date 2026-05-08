using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.Yharon;
using Steamworks;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public static class WeaponBossMappings
    {

        public static readonly Dictionary<string, List<List<int>>> Mapping = new()
        {
            { "PulseRifle", new List<List<int>>{ // A-PLS: Pulse Rifle
                    new() {ModContent.NPCType<DevourerofGodsHead>() }
            } },
            { "AbandonedSlimeStaff", new List<List<int>>{ // Abandoned Slime Staff
                    new() {ModContent.NPCType<AstrumAureus>() },
            } },
            { "AbsoluteZero", new List<List<int>>{ // Absolute Zero
                    new() {NPCID.Plantera},
            } },
            { "AbyssBlade", new List<List<int>>{ // Abyss Blade
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } },
            { "AbyssShocker", new List<List<int>>{ // Abyss Shocker
                    new() {NPCID.SkeletronHead},
            } },
            { "AbyssalTome", new List<List<int>>{ // Abyssal Tome 
                    new() {ModContent.NPCType<SlimeGodCore>()}
            } },
            { "AcidGun", new List<List<int>>{ // Acid Gun
                    new() {NPCID.EyeofCthulhu},
                    new() {NPCID.WallofFlesh}
            } },
            { "AcesHigh", new List<List<int>>{ // Ace's High
                    new() {ModContent.NPCType<Yharon>()}
            } },
            { "AcidwoodBow", new List<List<int>>() }, // Acidwood Bow
            { "AcidwoodSword", new List<List<int>>() }, // Acidwood Sword
            { "AdamantiteParticleAccelerator", new List<List<int>>{ // Adamantite Particle Accelerator
                    new() {NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism},
                    new() {NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime},
                    new() {NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } },
            { "AdamantiteThrowingAxe", new List<List<int>>{ // Adamantite Throwing Axe
                    new() {NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism},
                    new() {NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime},
                    new() {NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } },
            { "AegisBlade", new List<List<int>>{ // Aegis Blade
                    new() {NPCID.Golem}
            } },
            { "Aestheticus", new List<List<int>>{ // Aestheticus
                    new() {ModContent.NPCType<HiveMind>() },
                    new() {ModContent.NPCType<PerforatorHive>() }
            } },
            { "AethersWhisper", new List<List<int>>{ // Aether's Whisper
                    new() {ModContent.NPCType<Signus>() }
            } },
            { "AetherfluxCannon", new List<List<int>>{ // Aetherflux Cannon
                    new() {ModContent.NPCType<Yharon>()}
            } },
            { "AirSpinner", new List<List<int>>{ // Air Spinner
                    new() {ModContent.NPCType<HiveMind>() },
                    new() {ModContent.NPCType<PerforatorHive>() }
            } },
            { "Alluvion", new List<List<int>>{ // Alluvion
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } },
            { "AlphaDraconis", new List<List<int>>{ // Alpha Draconis
                    new() {ModContent.NPCType<Polterghast>()}
            } },
            { "AlulaAustralis", new List<List<int>>{ // Alula Australis
                    new() {ModContent.NPCType<AstrumAureus>()}
            } },
            { "AmidiasTrident", new List<List<int>>{ // Amidias' Trident
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } },
            { "AmphibiansGuitar", new List<List<int>>{ // Amphibian's Guitar
                    new() {NPCID.Plantera}
            } },
            { "AnahitasArpeggio", new List<List<int>>{ // Anahita's Arpeggio
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } },
            { "AnarchyBlade", new List<List<int>>{ // Anarchy Blade
                    new() {NPCID.Plantera}
            } },
            { "AncientIceChunk", new List<List<int>>{ // Ancient Ice Chunk
                    new() {NPCID.WallofFlesh}
            } },
            { "AngelicShotgun", new List<List<int>>{ // Angelic Shotgun
                    new() {ModContent.NPCType<Providence>()}
            } },
            { "Animosity", new List<List<int>>{ // Animosity
                    new() {ModContent.NPCType<CalamitasClone>()}
            } },
            { "AntiMaterielRifle", new List<List<int>>{ // Anti-materiel Rifle
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } },
            { "AntlionSkewer", new List<List<int>>() }, // Antlion Skewer
            { "Aorta", new List<List<int>>{ // Aorta
                    new() {ModContent.NPCType<PerforatorHive>()}
            } },
            { "Apathanull", new List<List<int>>{ // Apathanull
                    new() {NPCID.CultistBoss},
            } },
            { "Apoctolith", new List<List<int>>{ // Apoctolith
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()},
            } },
            { "ApoctosisArray", new List<List<int>>{ // Apoctosis Array
                    new() {NPCID.CultistBoss}
            } },
            { "Apotheosis", new List<List<int>>{ // Apotheosis
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } },
            { "AquasScepter", new List<List<int>>{ // Aqua's Scepter
                    new() {ModContent.NPCType<StormWeaverHead>()}
            } },
            { "AquamarineStaff", new List<List<int>>{ // Aquamarine Staff
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } },
            { "AquashardShotgun", new List<List<int>>{ // Aquashard Shotgun
                    new() {ModContent.NPCType<HiveMind>()},
                    new() {ModContent.NPCType<PerforatorHive>()}
            } },
            { "Arbalest", new List<List<int>>{ // Arbalest
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer},
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime}
            } },
            { "ArcNovaDiffuser", new List<List<int>>{ // Arc Nova Diffuser
                    new() {ModContent.NPCType<CalamitasClone>()}
            } },
            { "ArchAmaryllis", new List<List<int>>{ // Arch Amaryllis
                    new() {NPCID.CultistBoss}
            } },
            { "Archerfish", new List<List<int>>{ // Archerfish
                    new() {NPCID.SkeletronHead}
            } },
            { "ArcticBearPaw", new List<List<int>>{ // Arctic Bear Paw
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer, NPCID.SkeletronPrime}
            } },
            { "AresExoskeleton", new List<List<int>>{ // Ares' Exoskeleton
                    new() {ModContent.NPCType<Apollo>()}
            } },
            { "Arietes41", new List<List<int>>{ // Arietes 41
                    new() {NPCID.Plantera}
            } },
            { "TrueArkoftheAncients", new List<List<int>>{ // Ark of the Ancients
                    new() {NPCID.Plantera}
            } },
            { "ArkoftheCosmos", new List<List<int>>{ // Ark of the Cosmos
                    new() {ModContent.NPCType<Yharon>()}
            } },
            { "ArkoftheElements", new List<List<int>>{ // Ark of the Elements
                    new() {NPCID.MoonLordCore}
            } },
            { "ArtAttack", new List<List<int>>{ // Art Attack
                    new() {ModContent.NPCType<CalamitasClone>()}
            } },
            { "ArterialAssault", new List<List<int>>{ // Arterial Assault
                    new() {ModContent.NPCType<Providence>()},
            } },
            { "AshenStalactite", new List<List<int>>() }, // Ashen Stalactite
            { "AstralBlaster", new List<List<int>>{ // Astral Blaster
                    new() {ModContent.NPCType<AstrumDeusHead>(), NPCID.CultistBoss}
            } },
            { "AstralPike", new List<List<int>>{ // Astral Pike
                    new() {ModContent.NPCType<AstrumDeusHead>(), NPCID.CultistBoss}
            } },
            { "AstralScythe", new List<List<int>>{ // Astral Scythe
                    new() {ModContent.NPCType<AstrumAureus>()}
            } },
            { "AstralStaff", new List<List<int>>{ // Astral Staff
                    new() {ModContent.NPCType<AstrumDeusHead>(), NPCID.CultistBoss}
            } },
            { "AstralachneaStaff", new List<List<int>>{ // Astralachnea Staff
                    new() {ModContent.NPCType<AstrumAureus>()}
            } },
            { "AstrealDefeat", new List<List<int>>{ // Astreal Defeat
                    new() {NPCID.MoonLordCore}
            } },
            { "Ataraxia", new List<List<int>>{ // Ataraxia
                    new() {ModContent.NPCType<Yharon>()}
            } },
            { "Atlantis", new List<List<int>>{ // Atlantis
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } },
            { "AtlasMunitionsBeacon", new List<List<int>>{ // Atlas Munitions Beacon
                    new() {ModContent.NPCType<Apollo>()}
            } },
            { "AuguroftheVoid", new List<List<int>>{ // Augur of the Void
                    new() {NPCID.MoonLordCore}
            } },
            { "Auralis", new List<List<int>>{ // Auralis
                    new() {ModContent.NPCType<Providence>()}
            } },
            { "AuroraBlazer", new List<List<int>>{ // Aurora Blazer
                    new() {ModContent.NPCType<AstrumAureus>()}
            } },
            { "AuroradicalThrow", new List<List<int>>{ // Auroradical Throw
                    new() {ModContent.NPCType<AstrumAureus>()}
            } },
            { "Avalanche", new List<List<int>>{ // Avalanche
                    new() {ModContent.NPCType<Cryogen>()}
            } },
            { "Nidhogg", new List<List<int>>{ // B-GSS: Nidhogg
                    new() {ModContent.NPCType<PlaguebringerGoliath>()}
            } },
            { "CountermeasureMitt", new List<List<int>>{ // B-LSR: Countermeasure Mitt
                    new() {ModContent.NPCType<PlaguebringerGoliath>()}
            } },
            { "BalefulHarvester", new List<List<int>>{ // Baleful Harvester
                    new() {NPCID.CultistBoss}
            } },
            { "BallOFugu", new List<List<int>>{ // Ball O' Fugu
                    new() {NPCID.SkeletronHead}
            } },
            { "BallisticPoisonBomb", new List<List<int>>{ // Ballistic Poison Bomb
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } },
            { "BansheeHook", new List<List<int>>{ // Banshee Hook
                    new() {ModContent.NPCType<Polterghast>()}
            } },
            { "Barinade", new List<List<int>>{ // Barinade
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } },
            { "Barinautical", new List<List<int>>{ // Barinautical
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } },
            { "BarracudaGun", new List<List<int>>{ // Barracuda Gun
                    new() {NPCID.MoonLordCore}
            } },
            { "Basher", new List<List<int>>{ // Basher
                    new() {NPCID.EyeofCthulhu},
                    new() {NPCID.WallofFlesh}
            } },
            { "BelchingSaxophone", new List<List<int>>{ // Belching Saxophone
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } }, 
            { "BelladonnaSpiritStaff", new List<List<int>>() }, // Belladonna Spirit Staff
            { "Biofusillade", new List<List<int>>{ // Biofusillade
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "TrueBiomeBlade", new List<List<int>>{ // Biome Blade
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer, NPCID.SkeletronPrime}
            } }, 
            { "BlackAnurian", new List<List<int>>{ // Black Anurian
                    new() {NPCID.SkeletronHead}
            } }, 
            { "BlackHawkRemote", new List<List<int>>{ // Black Hawk Remote
                    new() {NPCID.WallofFlesh}
            } }, 
            { "BladecrestOathsword", new List<List<int>>() }, // Bladecrest Oathsword
            { "BladedgeRailbow", new List<List<int>>{ // Bladedge Railbow
                    new() {NPCID.Plantera}
            } }, 
            { "BlastBarrel", new List<List<int>>{ // Blast Barrel
                    new() {NPCID.WallofFlesh}
            } }, 
            { "BlazingStar", new List<List<int>>{ // Blazing Star
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "BlightSpewer", new List<List<int>>{ // Blight Spewer
                    new() {ModContent.NPCType<PlaguebringerGoliath>()}
            } }, 
            { "BlightedCleaver", new List<List<int>>{ // Blighted Cleaver
                    new() {NPCID.Plantera}
            } }, 
            { "BlissfulBombardier", new List<List<int>>{ // Blissful Bombardier
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "BloodBath", new List<List<int>>{ // Blood Bath
                    new() {ModContent.NPCType<PerforatorHive>()}
            } }, 
            { "BloodBoiler", new List<List<int>>{ // Blood Boiler
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "BloodsoakedCrasher", new List<List<int>>{ // Bloodsoaked Crasher
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "BlossomFlux", new List<List<int>>{ // Blossom Flux
                    new() {NPCID.Plantera}
            } }, 
            { "Bonebreaker", new List<List<int>>{ // Bonebreaker
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } }, 
            { "BorealisBomber", new List<List<int>>{ // Borealis Bomber
                    new() {ModContent.NPCType<AstrumAureus>()}
            } }, 
            { "BotanicPiercer", new List<List<int>>{ // Botanic Piercer
                    new() {NPCID.Plantera}
            } }, 
            { "BouncingEyeball", new List<List<int>>() }, // Bouncing Eyeball
            { "Brimblade", new List<List<int>>{ // Brimblade
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "Brimlance", new List<List<int>>{ // Brimlance
                    new() {ModContent.NPCType<BrimstoneElemental>()}
            } }, 
            { "Brimlash", new List<List<int>>{ // Brimlash
                    new() {ModContent.NPCType<CalamitasClone>()}
            } }, 
            { "BrimroseStaff", new List<List<int>>{ // Brimrose Staff
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "BrimstoneFury", new List<List<int>>{ // Brimstone Fury
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "BrimstoneSword", new List<List<int>>{ // Brimstone Sword
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}    
            } }, 
            { "BrinyBaron", new List<List<int>>{ // Briny Baron
                    new() {NPCID.DukeFishron}
            } }, 
            { "BrittleStarStaff", new List<List<int>>{ // Brittle Star Staff
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { "BrokenBiomeBlade", new List<List<int>>{ // Broken Biome Blade
                    new() {ModContent.NPCType<HiveMind>()},
                    new() {ModContent.NPCType<PerforatorHive>()}
            } },
            { "BulletFilledShotgun", new List<List<int>>{ // Bullet-Filled Shotgun
                    new() {ModContent.NPCType<HiveMind>()},
                    new() {ModContent.NPCType<PerforatorHive>()}
            } }, 
            { "BurningRevelation", new List<List<int>>{ // Burning Revelation
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "BurningSea", new List<List<int>>{ // Burning Sea
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "BurningStrife", new List<List<int>>() }, // Burning Strife
            { "BurntSienna", new List<List<int>>() }, // Burnt Sienna
            { "Buzzkill", new List<List<int>>{ // Buzzkill
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "CadaverousCarrion", new List<List<int>>{ // Cadaverous Carrion
                    new() {ModContent.NPCType<OldDuke>()}
            } }, 
            { "CalamarisLament", new List<List<int>>{ // Calamari's Lament
                    new() {ModContent.NPCType<Polterghast>()}
            } }, 
            { "Carnage", new List<List<int>>{ // Carnage
                    new() {NPCID.WallofFlesh}
            } }, 
            { "CausticCroakerStaff", new List<List<int>>{ // Caustic Croaker Staff
                    new() {NPCID.EyeofCthulhu},
                    new() {NPCID.WallofFlesh}
            } }, 
            { "TrueCausticEdge", new List<List<int>>{ // Caustic Edge
                    new() {NPCID.WallofFlesh}
            } }, 
            { "CausticStaff", new List<List<int>>{ // Caustic Staff
                    new() {NPCID.WallofFlesh}
            } }, 
            { "CelestialClaymore", new List<List<int>>{ // Celestial Claymore
                    new() {NPCID.WallofFlesh}
            } }, 
            { "CelestialReaper", new List<List<int>>{ // Celestial Reaper
                    new() {NPCID.MoonLordCore}
            } }, 
            { "Celestus", new List<List<int>>{ // Celestus
                    new() {ModContent.NPCType<Apollo>()}
            } }, 
            { "ChickenCannon", new List<List<int>>{ // Chicken Cannon
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { "ChromaticEruption", new List<List<int>>{ // Chromatic Eruption
                    new() {NPCID.MoonLordCore}
            } }, 
            { "ChronomancersScythe", new List<List<int>>{ // Chronomancer's Scythe
                    new() {NPCID.MoonLordCore}
            } }, 
            { "CinderBlossomStaff", new List<List<int>>{ // Cinder Blossom Staff
                    new() {NPCID.BrainofCthulhu},
                    new() {NPCID.EaterofWorldsHead}
            } }, 
            { "CindersOfLament", new List<List<int>>{ // Cinders of Lament
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } }, 
            { "Cinquedea", new List<List<int>>{ // Cinquedea
                    new() {NPCID.SkeletronHead}
            } }, 
            { "ClamCrusher", new List<List<int>>{ // Clam Crusher
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { "ClamorRifle", new List<List<int>>{ // Clamor Rifle
                    new() {NPCID.WallofFlesh}
            } }, 
            { "ClaretCannon", new List<List<int>>{ // Claret Cannon
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "CleansingBlaze", new List<List<int>>{ // Cleansing Blaze
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "ClockworkBow", new List<List<int>>{ // Clockwork Bow
                    new() {NPCID.MoonLordCore}
            } }, 
            { "ClothiersWrath", new List<List<int>>{ // Clothier's Wrath
                    new() {NPCID.SkeletronHead}
            } }, 
            { "Cnidarian", new List<List<int>>{ // Cnidarian
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { "CobaltKunai", new List<List<int>>{ // Cobalt Kunai
                    new() {NPCID.WallofFlesh}
            } }, 
            { "ColdheartIcicle", new List<List<int>>{ // Coldheart Icicle
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } }, 
            { "CometQuasher", new List<List<int>>{ // Comet Quasher
                    new() {NPCID.WallofFlesh}
            } }, 
            { "Condemnation", new List<List<int>>{ // Condemnation
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } }, 
            { "ConferenceCall", new List<List<int>>{ // Conference Call
                    new() {NPCID.CultistBoss}
            } }, 
            { "ConsecratedWater", new List<List<int>>{ // Consecrated Water
                    new() {NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism},
                    new() {NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime},
                    new() {NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { "Contagion", new List<List<int>>{ // Contagion
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } }, 
            { "ContaminatedBile", new List<List<int>>() }, // Contaminated Bile
            { "ContinentalGreatbow", new List<List<int>>{ // Continental Greatbow
                    new() {NPCID.Golem}
            } }, 
            { "CoralSpout", new List<List<int>>{ // Coral Spout
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { "CorinthPrime", new List<List<int>>{ // Corinth Prime
                    new() {ModContent.NPCType<StormWeaverHead>()}
            } }, 
            { "CorpusAvertor", new List<List<int>>{ // Corpus Avertor
                    new() {ModContent.NPCType<RavagerBody>()}
            } }, 
            { "CorrodedCaustibow", new List<List<int>>{ // Corroded Caustibow
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } }, 
            { "CorroslimeStaff", new List<List<int>>{ // Corroslime Staff
                    new() {ModContent.NPCType<SlimeGodCore>()}
            } }, 
            { "CorvidHarbringerStaff", new List<List<int>>{ // Corvid Harbinger Staff
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "CosmicDischarge", new List<List<int>>{ // Cosmic Discharge
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "CosmicImmaterializer", new List<List<int>>{ // Cosmic Immaterializer
                    new() {ModContent.NPCType<Apollo>()}
            } }, 
            { "CosmicKunai", new List<List<int>>{ // Cosmic Kunai
                    new() {ModContent.NPCType<Signus>()}
            } }, 
            { "CosmicRainbow", new List<List<int>>{ // Cosmic Rainbow
                    new() {NPCID.MoonLordCore}
            } }, 
            { "CosmicShiv", new List<List<int>>{ // Cosmic Shiv
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "CosmicViperEngine", new List<List<int>>{ // Cosmic Viper Engine
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "Cosmilamp", new List<List<int>>{ // Cosmilamp
                    new() {ModContent.NPCType<Signus>()}
            } }, 
            { "CrackshotColt", new List<List<int>>() }, // Crackshot Colt
            { "CraniumSmasher", new List<List<int>>{ // Cranium Smasher
                    new() {ModContent.NPCType<RavagerBody>()}
            } }, 
            { "CrescentMoon", new List<List<int>>{ // Crescent Moon
                    new() {ModContent.NPCType<Polterghast>()}
            } }, 
            { "CrimslimeStaff", new List<List<int>>{ // Crimslime Staff
                    new() {ModContent.NPCType<SlimeGodCore>()}
            } }, 
            { "CrushsawCrasher", new List<List<int>>{ // Crushsaw Crasher
                    new() {ModContent.NPCType<CalamitasClone>()}
            } }, 
            { "CryogenicStaff", new List<List<int>>{ // Cryogenic Staff
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer, NPCID.SkeletronPrime}
            } }, 
            { "Cryophobia", new List<List<int>>{ // Cryophobia
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer, NPCID.SkeletronPrime}
            } }, 
            { "CrystalPiercer", new List<List<int>>{ // Crystal Piercer
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { "Crystalline", new List<List<int>>() }, // Crystalline    
            { "CursedDagger", new List<List<int>>{ // Cursed Dagger
                    new() {NPCID.WallofFlesh}
            } }, 
            { "DaedalusGolemStaff", new List<List<int>>{ // Daedalus Golem Staff
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { "DaemonsFlame", new List<List<int>>{ // Daemon's Flame
                    new() {ModContent.NPCType<Polterghast>()}
            } }, 
            { "DankStaff", new List<List<int>>{ // Dank Staff
                    new() {ModContent.NPCType<HiveMind>()}
            } }, 
            { "DarkSpark", new List<List<int>>{ // Dark Spark
                    new() {ModContent.NPCType<CeaselessVoid>(), ModContent.NPCType<Polterghast>()}
            } }, 
            { "DarkechoGreatbow", new List<List<int>>{ // Darkecho Greatbow
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { "DarklightGreatsword", new List<List<int>>{ // Darklight Greatsword
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime},
                    new() {ModContent.NPCType<Cryogen>(), NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { "DazzlingStabberStaff", new List<List<int>>{ // Dazzling Stabber Staff
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "DeadSunsWind", new List<List<int>>{ // Dead Sun's Wind
                    new() {NPCID.CultistBoss}
            } }, 
            { "DeathValleyDuster", new List<List<int>>{ // Death Valley Duster
                    new() {NPCID.WallofFlesh}
            } }, 
            { "DeathsAscension", new List<List<int>>{ // Death's Ascension
                    new() {ModContent.NPCType<Polterghast>(), ModContent.NPCType<Signus>()}
            } }, 
            { "DeathstareRod", new List<List<int>>{ // Deathstare Rod
                    new() {NPCID.EyeofCthulhu}
            } }, 
            { "DeepSeaDumbbell", new List<List<int>>{ // Deep Sea Dumbbell
                    new() {ModContent.NPCType<Polterghast>()}
            } }, 
            { "DeepWounder", new List<List<int>>{ // Deep Wounder
                    new() {ModContent.NPCType<CalamitasClone>()}
            } }, 
            { "DeepcoreGK2", new List<List<int>>{ // Deepcore GK2
                    new() {NPCID.Spazmatism, NPCID.Retinazer},
                    new() {NPCID.TheDestroyer},
                    new() {NPCID.SkeletronPrime}
            } }, 
            { "DeepseaStaff", new List<List<int>>{ // Deepsea Staff
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } }, 
            { "DefectiveSphere", new List<List<int>>{ // Defective Sphere
                    new() {NPCID.Plantera}
            } }, 
            { "DefiledGreatsword", new List<List<int>>{ // Defiled Greatsword
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "DepthCrusher", new List<List<int>>() }, // Depth Crusher
            { "DesecratedWater", new List<List<int>>{ // Desecrated Water
                    new() {NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism},
                    new() {NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime},
                    new() {NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { "DevilsDevastation", new List<List<int>>{ // Devil's Devastation
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "DevilsSunrise", new List<List<int>>{ // Devil's Sunrise
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "DimensionTearingDisk", new List<List<int>>{ // Dimension-Tearing Disk
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { "DoomsdayDevice", new List<List<int>>{ // Doomsday Device
                    new() {NPCID.Golem}
            } }, 
            { "DormantBrimseeker", new List<List<int>>{ // Dormant Brimseeker
                    new() {ModContent.NPCType<BrimstoneElemental>()}
            } }, 
            { "Downpour", new List<List<int>>{ // Downpour
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } }, 
            { "DraconicDestruction", new List<List<int>>{ // Draconic Destruction
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } }, 
            { "DragonPow", new List<List<int>>{ // Dragon Pow
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { "DragonRage", new List<List<int>>{ // Dragon Rage
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { "DragonsBreath", new List<List<int>>{ // Dragon's Breath
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { "DragonbloodDisgorger", new List<List<int>>{ // Dragonblood Disgorger
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { "Drataliornus", new List<List<int>>{ // Drataliornus
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { "DreadmineStaff", new List<List<int>>{ // Dreadmine Staff
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } }, 
            { "DriftwoodBow", new List<List<int>>() }, // Driftwood Bow
            { "DriftwoodSword", new List<List<int>>() }, // Driftwood Sword
            { "DukesDecapitator", new List<List<int>>{ // Duke's Decapitator
                    new() {NPCID.DukeFishron}
            } }, 
            { "DuststormInABottle", new List<List<int>>{ // Duststorm in a Bottle
                    new() {NPCID.Plantera}
            } }, 
            { "DynamicPursuer", new List<List<int>>{ // Dynamic Pursuer
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { "Earth", new List<List<int>>() }, // Earth
            { "EarthenPike", new List<List<int>>() }, // Earthen Pike
            { "EclipsesFall", new List<List<int>>() }, // Eclipse's Fall
            { "Effervescence", new List<List<int>>() }, // Effervescence
            { "EidolicWail", new List<List<int>>() }, // Eidolic Wail
            { "EidolonStaff", new List<List<int>>() }, // Eidolon Staff
            { "EldritchTome", new List<List<int>>() }, // Eldritch Tome
            { "EmpyreanKnives", new List<List<int>>() }, // Empyrean Knives
            { "EnchantedAxe", new List<List<int>>() }, // Enchanted Axe
            { "EnchantedConch", new List<List<int>>() }, // Enchanted Conch
            { "EnchantedKnifeStaff", new List<List<int>>() }, // Enchanted Knife Staff
            { "EndoHydraStaff", new List<List<int>>() }, // Endo Hydra Staff
            { "Endogenesis", new List<List<int>>() }, // Endogenesis
            { "EntropicClaymore", new List<List<int>>() }, // Entropic Claymore
            { "EntropysVigil", new List<List<int>>() }, // Entropy's Vigil
            { "EpidemicShredder", new List<List<int>>() }, // Epidemic Shredder
            { "Equanimity", new List<List<int>>() }, // Equanimity
            { "EssenceFlayer", new List<List<int>>() }, // Essence Flayer
            { "EternalBlizzard", new List<List<int>>() }, // Eternal Blizzard
            { "Eternity", new List<List<int>>() }, // Eternity
            { "EtherealSubjugator", new List<List<int>>() }, // Ethereal Subjugator
            { "EventHorizon", new List<List<int>>() }, // Event Horizon
            { "EvergladeSpray", new List<List<int>>() }, // Everglade Spray
            { "EvilSmasher", new List<List<int>>() }, // Evil Smasher
            { "Eviscerator", new List<List<int>>() }, // Eviscerator
            { "ExaltedOathblade", new List<List<int>>() }, // Exalted Oathblade
            { "ExecutionersBlade", new List<List<int>>() }, // Executioner's Blade
            { "Exoblade", new List<List<int>>() }, // Exoblade
            { "Exorcism", new List<List<int>>() }, // Exorcism
            { "EyeofMagnus", new List<List<int>>() }, // Eye of Magnus
            { "EyeOfNight", new List<List<int>>() }, // Eye of Night
            { "FaceMelter", new List<List<int>>() }, // Face Melter
            { "FallenPaladinsHammer", new List<List<int>>() }, // Fallen Paladin's Hammer
            { "FantasyTalisman", new List<List<int>>() }, // Fantasy Talisman
            { "FatesReveal", new List<List<int>>() }, // Fate's Reveal
            { "FaultLine", new List<List<int>>() }, // Fault Line
            { "FeatherKnife", new List<List<int>>() }, // Feather Knife
            { "FeralthornClaymore", new List<List<int>>() }, // Feralthorn Claymore
            { "FetidEmesis", new List<List<int>>() }, // Fetid Emesis
            { "FirestormCannon", new List<List<int>>() }, // Firestorm Cannon
            { "FishboneBoomerang", new List<List<int>>() }, // Fishbone Boomerang
            { "FlakKraken", new List<List<int>>() }, // Flak Kraken
            { "FlakToxicannon", new List<List<int>>() }, // Flak Toxicannon
            { "FlamsteedRing", new List<List<int>>() }, // Flamsteed Ring
            { "FlareBolt", new List<List<int>>() }, // Flare Bolt
            { "FlarefrostBlade", new List<List<int>>() }, // Flarefrost Blade
            { "FlarewingBow", new List<List<int>>() }, // Flarewing Bow
            { "FleshOfInfidelity", new List<List<int>>() }, // Flesh of Infidelity
            { "Floodtide", new List<List<int>>() }, // Floodtide
            { "FlowersOfMortality", new List<List<int>>() }, // Flowers of Mortality
            { "FlurrystormCannon", new List<List<int>>() }, // Flurrystorm Cannon
            { "ForbiddenOathblade", new List<List<int>>() }, // Forbidden Oathblade
            { "ForbiddenSun", new List<List<int>>() }, // Forbidden Sun
            { "ForgottenApexWand", new List<List<int>>() }, // Forgotten Apex Wand
            { "ForsakenSaber", new List<List<int>>() }, // Forsaken Saber
            { "FracturedArk", new List<List<int>>() }, // Fractured Ark
            { "FreedomStar", new List<List<int>>() }, // Freedom Star
            { "FrigidflashBolt", new List<List<int>>() }, // Frigidflash Bolt
            { "FrostBlossomStaff", new List<List<int>>() }, // Frost Blossom Staff
            { "FrostBolt", new List<List<int>>() }, // Frost Bolt
            { "FrostbiteBlaster", new List<List<int>>() }, // Frostbite Blaster
            { "FrostcrushValari", new List<List<int>>() }, // Frostcrush Valari
            { "FrostyFlare", new List<List<int>>() }, // Frosty Flare
            { "FuelCellBundle", new List<List<int>>() }, // Fuel Cell Bundle
            { "Fungicide", new List<List<int>>() }, // Fungicide
            { "GacruxianMollusk", new List<List<int>>() }, // Gacruxian Mollusk
            { "GaelsGreatsword", new List<List<int>>() }, // Gael's Greatsword
            { "GalactusBlade", new List<List<int>>() }, // Galactus Blade
            { "FourSeasonsGalaxia", new List<List<int>>() }, // Galaxia
            { "GalaxySmasher", new List<List<int>>() }, // Galaxy Smasher
            { "Galeforce", new List<List<int>>() }, // Galeforce
            { "GalileoGladius", new List<List<int>>() }, // Galileo Gladius
            { "GalvanizingGlaive", new List<List<int>>() }, // Galvanizing Glaive
            { "GammaHeart", new List<List<int>>() }, // Gamma Heart
            { "GastricBelcherStaff", new List<List<int>>() }, // Gastric Belcher Staff
            { "GelDart", new List<List<int>>() }, // Gel Dart
            { "GeliticBlade", new List<List<int>>() }, // Gelitic Blade
            { "Genesis", new List<List<int>>() }, // Genesis
            { "GhastlyVisage", new List<List<int>>() }, // Ghastly Visage
            { "GhoulishGouger", new List<List<int>>() }, // Ghoulish Gouger
            { "GildedDagger", new List<List<int>>() }, // Gilded Dagger
            { "GildedProboscis", new List<List<int>>() }, // Gilded Proboscis
            { "GlacialEmbrace", new List<List<int>>() }, // Glacial Embrace
            { "Glaive", new List<List<int>>() }, // Glaive
            { "GleamingDagger", new List<List<int>>() }, // Gleaming Dagger
            { "GleamingMagnolia", new List<List<int>>() }, // Gleaming Magnolia
            { "GloriousEnd", new List<List<int>>() }, // Glorious End
            { "GodsParanoia", new List<List<int>>() }, // Gods' Paranoia
            { "GoldenEagle", new List<List<int>>() }, // Golden Eagle
            { "GoldplumeSpear", new List<List<int>>() }, // Goldplume Spear
            { "Goobow", new List<List<int>>() }, // Goobow
            { "GrandDad", new List<List<int>>() }, // Grand Dad
            { "GrandGuardian", new List<List<int>>() }, // Grand Guardian
            { "GraveGrimreaver", new List<List<int>>() }, // Grave Grimreaver
            { "GreatswordofJudgement", new List<List<int>>() }, // Greatsword of Judgement
            { "Greentide", new List<List<int>>() }, // Greentide
            { "GruesomeEminence", new List<List<int>>() }, // Gruesome Eminence
            { "GuidelightofOblivion", new List<List<int>>() }, // Guidelight of Oblivion
            { "GunkShot", new List<List<int>>() }, // Gunk Shot
            { "HadalUrn", new List<List<int>>() }, // Hadal Urn
            { "HalibutCannon", new List<List<int>>() }, // Halibut Cannon
            { "HalleysInferno", new List<List<int>>() }, // Halley's Inferno
            { "HandheldTank", new List<List<int>>() }, // Handheld Tank
            { "HardenedHoneycomb", new List<List<int>>() }, // Hardened Honeycomb
            { "HarvestStaff", new List<List<int>>() }, // Harvest Staff
            { "HauntedScroll", new List<List<int>>() }, // Haunted Scroll
            { "HavocsBreath", new List<List<int>>() }, // Havoc's Breath
            { "HeavenfallenStardisk", new List<List<int>>() }, // Heavenfallen Stardisk
            { "HeavenlyGale", new List<List<int>>() }, // Heavenly Gale
            { "HeliumFlash", new List<List<int>>() }, // Helium Flash
            { "Hellborn", new List<List<int>>() }, // Hellborn
            { "HellfireFlamberge", new List<List<int>>() }, // Hellfire Flamberge
            { "HellionFlowerSpear", new List<List<int>>() }, // Hellion Flower Spear
            { "Hellkite", new List<List<int>>() }, // Hellkite
            { "HellwingStaff", new List<List<int>>() }, // Hellwing Staff
            { "Helstorm", new List<List<int>>() }, // Helstorm
            { "Hematemesis", new List<List<int>>() }, // Hematemesis
            { "Heresy", new List<List<int>>() }, // Heresy
            { "HerringStaff", new List<List<int>>() }, // Herring Staff
            { "HivePod", new List<List<int>>() }, // Hive Pod
            { "HoarfrostBow", new List<List<int>>() }, // Hoarfrost Bow
            { "HolyCollider", new List<List<int>>() }, // Holy Collider
            { "Hydra", new List<List<int>>() }, // Hydra
            { "HydraulicVoltCrasher", new List<List<int>>() }, // Hydraulic Volt Crasher
            { "HyperdeathRiftScepter", new List<List<int>>() }, // Hyperdeath Rift Scepter
            { "HyphaeRod", new List<List<int>>() }, // Hyphae Rod
            { "Hypothermia", new List<List<int>>() }, // Hypothermia
            { "IceBarrage", new List<List<int>>() }, // Ice Barrage
            { "IceStar", new List<List<int>>() }, // Ice Star
            { "Icebreaker", new List<List<int>>() }, // Icebreaker
            { "IchorSpear", new List<List<int>>() }, // Ichor Spear
            { "IcicleStaff", new List<List<int>>() }, // Icicle Staff
            { "IcicleTrident", new List<List<int>>() }, // Icicle Trident
            { "IgneousExaltation", new List<List<int>>() }, // Igneous Exaltation
            { "IllustriousKnives", new List<List<int>>() }, // Illustrious Knives
            { "InfectedRemote", new List<List<int>>() }, // Infected Remote
            { "InfernalKris", new List<List<int>>() }, // Infernal Kris
            { "InfernalRift", new List<List<int>>() }, // Infernal Rift
            { "InfestedClawmerang", new List<List<int>>() }, // Infested Clawmerang
            { "Infinity", new List<List<int>>() }, // Infinity
            { "InsidiousImpaler", new List<List<int>>() }, // Insidious Impaler
            { "IonBlaster", new List<List<int>>() }, // Ion Blaster
            { "IronFrancisca", new List<List<int>>() }, // Iron Francisca
            { "JawsOfOblivion", new List<List<int>>() }, // Jaws of Oblivion
            { "Karasawa", new List<List<int>>() }, // Karasawa
            { "Keelhaul", new List<List<int>>() }, // Keelhaul
            { "KelvinCatalyst", new List<List<int>>() }, // Kelvin Catalyst
            { "KingofConstellationsTenryu", new List<List<int>>() }, // King of Constellations, Tenryū
            { "Kingsbane", new List<List<int>>() }, // Kingsbane
            { "Kylie", new List<List<int>>() }, // Kylie
            { "Lacerator", new List<List<int>>() }, // Lacerator
            { "LashesofChaos", new List<List<int>>() }, // Lashes of Chaos
            { "LeadTomahawk", new List<List<int>>() }, // Lead Tomahawk
            { "LegionofCelestia", new List<List<int>>() }, // Legion of Celestia
            { "LeonidProgenitor", new List<List<int>>() }, // Leonid Progenitor
            { "LeviathanTeeth", new List<List<int>>() }, // Leviathan Teeth
            { "Leviatitan", new List<List<int>>() }, // Leviatitan
            { "LifehuntScythe", new List<List<int>>() }, // Lifehunt Scythe
            { "LightGodsBrilliance", new List<List<int>>() }, // Light God's Brilliance
            { "Lightspeed", new List<List<int>>() }, // Lightspeed
            { "LiliesOfFinality", new List<List<int>>() }, // Lilies of Finality
            { "LionHeart", new List<List<int>>() }, // Lion Heart
            { "Lionfish", new List<List<int>>() }, // Lionfish
            { "Lucrecia", new List<List<int>>() }, // Lucrecia
            { "LunarKunai", new List<List<int>>() }, // Lunar Kunai
            { "LunarianBow", new List<List<int>>() }, // Lunarian Bow
            { "LunicEye", new List<List<int>>() }, // Lunic Eye
            { "M1Garand", new List<List<int>>() }, // M1 Garand
            { "MadAlchemistsCocktailGlove", new List<List<int>>() }, // Mad Alchemist's Cocktail Glove
            { "MagnaCannon", new List<List<int>>() }, // Magna Cannon
            { "MagneticMeltdown", new List<List<int>>() }, // Magnetic Meltdown
            { "MagnomalyCannon", new List<List<int>>() }, // Magnomaly Cannon
            { "MajesticGuard", new List<List<int>>() }, // Majestic Guard
            { "Malachite", new List<List<int>>() }, // Malachite
            { "Malevolence", new List<List<int>>() }, // Malevolence
            { "ManaRose", new List<List<int>>() }, // Mana Rose
            { "MangroveChakram", new List<List<int>>() }, // Mangrove Chakram
            { "MantisClaws", new List<List<int>>() }, // Mantis Claws
            { "MarksmanBow", new List<List<int>>() }, // Marksman Bow
            { "MawOfInfinity", new List<List<int>>() }, // Maw of Infinity
            { "Megalodon", new List<List<int>>() }, // Megalodon
            { "Meowthrower", new List<List<int>>() }, // Meowthrower
            { "MetalMonstrosity", new List<List<int>>() }, // Metal Monstrosity
            { "Metastasis", new List<List<int>>() }, // Metastasis
            { "MeteorFist", new List<List<int>>() }, // Meteor Fist
            { "Miasma", new List<List<int>>() }, // Miasma
            { "MidasPrime", new List<List<int>>() }, // Midas Prime
            { "MidnightSunBeacon", new List<List<int>>() }, // Midnight Sun Beacon
            { "MineralMortar", new List<List<int>>() }, // Mineral Mortar
            { "MirrorBlade", new List<List<int>>() }, // Mirror Blade
            { "MirrorofKalandra", new List<List<int>>() }, // Mirror of Kalandra
            { "Mistlestorm", new List<List<int>>() }, // Mistlestorm
            { "MoltenAmputator", new List<List<int>>() }, // Molten Amputator
            { "MonolithBow", new List<List<int>>() }, // Monolith Bow
            { "MonolithSword", new List<List<int>>() }, // Monolith Sword
            { "Monsoon", new List<List<int>>() }, // Monsoon
            { "MonstrousKnives", new List<List<int>>() }, // Monstrous Knives
            { "MountedScanner", new List<List<int>>() }, // Mounted Scanner
            { "Mourningstar", new List<List<int>>() }, // Mourningstar
            { "Murasama", new List<List<int>>() }, // Murasama
            { "MutatedTruffle", new List<List<int>>() }, // Mutated Truffle
            { "MycelialClaws", new List<List<int>>() }, // Mycelial Claws
            { "Mycoroot", new List<List<int>>() }, // Mycoroot
            { "MythrilKnife", new List<List<int>>() }, // Mythril Knife
            { "Nadir", new List<List<int>>() }, // Nadir
            { "NanoPurge", new List<List<int>>() }, // Nano Purge
            { "NanoblackReaper", new List<List<int>>() }, // Nanoblack Reaper
            { "NastyCholla", new List<List<int>>() }, // Nasty Cholla
            { "Nebulash", new List<List<int>>() }, // Nebulash
            { "NebulousCataclysm", new List<List<int>>() }, // Nebulous Cataclysm
            { "Needler", new List<List<int>>() }, // Needler
            { "NeptunesBounty", new List<List<int>>() }, // Neptune's Bounty
            { "NettlevineGreatbow", new List<List<int>>() }, // Nettlevine Greatbow
            { "NightsRay", new List<List<int>>() }, // Night's Ray
            { "NitroExpressRifle", new List<List<int>>() }, // Nitro Express Rifle
            { "Norfleet", new List<List<int>>() }, // Norfleet
            { "NuclearFury", new List<List<int>>() }, // Nuclear Fury
            { "Nucleosynthesis", new List<List<int>>() }, // Nucleosynthesis
            { "NullificationPistol", new List<List<int>>() }, // Nullification Pistol
            { "Oblivion", new List<List<int>>() }, // Oblivion
            { "OldLordClaymore", new List<List<int>>() }, // Old Lord Claymore
            { "Omicron", new List<List<int>>() }, // Omicron
            { "Omniblade", new List<List<int>>() }, // Omniblade
            { "OntologicalDespoiler", new List<List<int>>() }, // Ontological Despoiler
            { "OnyxChainBlaster", new List<List<int>>() }, // Onyx Chain Blaster
            { "Onyxia", new List<List<int>>() }, // Onyxia
            { "OpalStriker", new List<List<int>>() }, // Opal Striker
            { "Orderbringer", new List<List<int>>() }, // Orderbringer
            { "OrichalcumSpikedGemstone", new List<List<int>>() }, // Orichalcum Spiked Gemstone
            { "OrthoceraShell", new List<List<int>>() }, // Orthocera Shell
            { "OverloadedBlaster", new List<List<int>>() }, // Overloaded Blaster
            { "Ozzathoth", new List<List<int>>() }, // Ozzathoth
            { "Auger", new List<List<int>>() }, // P-GSS: Auger
            { "AerialTracker", new List<List<int>>() }, // P-LSR: Aerial Tracker
            { "PulsePistol", new List<List<int>>() }, // P-PLS: Pulse Pistol
            { "AqueousHunterDrone", new List<List<int>>() }, // P-PMA: Aqueous Hunter Drone
            { "ShortCircuit", new List<List<int>>() }, // P-TSL: Short Circuit
            { "P90", new List<List<int>>() }, // P90
            { "PalladiumJavelin", new List<List<int>>() }, // Palladium Javelin
            { "Pandemic", new List<List<int>>() }, // Pandemic
            { "ParasiticSceptor", new List<List<int>>() }, // Parasitic Scepter
            { "PearlGod", new List<List<int>>() }, // Pearl God
            { "Penumbra", new List<List<int>>() }, // Penumbra
            { "Perdition", new List<List<int>>() }, // Perdition
            { "PerfectDark", new List<List<int>>() }, // Perfect Dark
            { "PestilentDefiler", new List<List<int>>() }, // Pestilent Defiler
            { "PhantasmalFury", new List<List<int>>() }, // Phantasmal Fury
            { "PhantasmalRuin", new List<List<int>>() }, // Phantasmal Ruin
            { "Phaseslayer", new List<List<int>>() }, // Phaseslayer
            { "PhoenixFlameBarrage", new List<List<int>>() }, // Phoenix Flame Barrage
            { "PhosphorescentGauntlet", new List<List<int>>() }, // Phosphorescent Gauntlet
            { "PhotonRipper", new List<List<int>>() }, // Photon Ripper
            { "Photosynthesis", new List<List<int>>() }, // Photosynthesis
            { "Photoviscerator", new List<List<int>>() }, // Photoviscerator
            { "PlagueStaff", new List<List<int>>() }, // Plague Staff
            { "PlagueTaintedSMG", new List<List<int>>() }, // Plague Tainted SMG
            { "Plaguenade", new List<List<int>>() }, // Plaguenade
            { "PlanetaryAnnihilation", new List<List<int>>() }, // Planetary Annihilation
            { "PlantationStaff", new List<List<int>>() }, // Plantation Staff
            { "PlasmaCaster", new List<List<int>>() }, // Plasma Caster
            { "PlasmaGrenade", new List<List<int>>() }, // Plasma Grenade
            { "PlasmaRifle", new List<List<int>>() }, // Plasma Rifle
            { "PlasmaRod", new List<List<int>>() }, // Plasma Rod
            { "PolarisParrotfish", new List<List<int>>() }, // Polaris Parrotfish
            { "PoleWarper", new List<List<int>>() }, // Pole Warper
            { "PolypLauncher", new List<List<int>>() }, // Polyp Launcher
            { "Poseidon", new List<List<int>>() }, // Poseidon
            { "PridefulHuntersPlanarRipper", new List<List<int>>() }, // Prideful Hunter's Planar Ripper
            { "PrimordialAncient", new List<List<int>>() }, // Primordial Ancient
            { "PrimordialEarth", new List<List<int>>() }, // Primordial Earth
            { "Prismalline", new List<List<int>>() }, // Prismalline
            { "PrismaticBreaker", new List<List<int>>() }, // Prismatic Breaker
            { "PristineFury", new List<List<int>>() }, // Pristine Fury
            { "ProfanedPartisan", new List<List<int>>() }, // Profaned Partisan
            { "PuffShroom", new List<List<int>>() }, // Puff Shroom
            { "PulseDragon", new List<List<int>>() }, // Pulse Dragon
            { "PulseTurretRemote", new List<List<int>>() }, // Pulse Turret Remote
            { "Pumpkaboom", new List<List<int>>() }, // Pumpkaboom
            { "Pumpler", new List<List<int>>() }, // Pumpler
            { "PurgeGuzzler", new List<List<int>>() }, // Purge Guzzler
            { "Pwnagehammer", new List<List<int>>() }, // Pwnagehammer
            { "Quagmire", new List<List<int>>() }, // Quagmire
            { "Vulcan", new List<List<int>>() }, // R-GSS: Vulcan
            { "PulseGrenade", new List<List<int>>() }, // R-PLS: Pulse Grenade
            { "HolofibreImmolator", new List<List<int>>() }, // R-PMA: Holofibre Immolator
            { "RadiantStar", new List<List<int>>() }, // Radiant Star
            { "RainbowPartyCannon", new List<List<int>>() }, // Rainbow Party Cannon
            { "Rancor", new List<List<int>>() }, // Rancor
            { "RealityRupture", new List<List<int>>() }, // Reality Rupture
            { "RealmRavager", new List<List<int>>() }, // Realm Ravager
            { "ReboundingRainbow", new List<List<int>>() }, // Rebounding Rainbow
            { "RecitationoftheBeast", new List<List<int>>() }, // Recitation of the Beast
            { "RedSun", new List<List<int>>() }, // Red Sun
            { "ReedBlowgun", new List<List<int>>() }, // Reed Blowgun
            { "RefractionRotor", new List<List<int>>() }, // Refraction Rotor
            { "RegulusRiot", new List<List<int>>() }, // Regulus Riot
            { "RelicOfDeliverance", new List<List<int>>() }, // Relic of Deliverance
            { "RelicofRuin", new List<List<int>>() }, // Relic of Ruin
            { "RemsRevenge", new List<List<int>>() }, // Rem's Revenge
            { "Respiteblock", new List<List<int>>() }, // Respiteblock
            { "ResurrectionButterfly", new List<List<int>>() }, // Resurrection Butterfly
            { "Riftburst", new List<List<int>>() }, // Riftburst
            { "Riptide", new List<List<int>>() }, // Riptide
            { "RotBall", new List<List<int>>() }, // Rot Ball
            { "RougeSlash", new List<List<int>>() }, // Rouge Slash
            { "Roxcalibur", new List<List<int>>() }, // Roxcalibur
            { "RubicoPrime", new List<List<int>>() }, // Rubico Prime
            { "RustyBeaconPrototype", new List<List<int>>() }, // Rusty Beacon Prototype
            { "Sacrifice", new List<List<int>>() }, // Sacrifice
            { "SaharaSlicers", new List<List<int>>() }, // Sahara Slicers
            { "SamsaraSlicer", new List<List<int>>() }, // Samsara Slicer
            { "SanctifiedSpark", new List<List<int>>() }, // Sanctified Spark
            { "SandDollar", new List<List<int>>() }, // Sand Dollar
            { "SandSharknadoStaff", new List<List<int>>() }, // Sand Sharknado Staff
            { "Sandblaster", new List<List<int>>() }, // Sandblaster
            { "SandstreamScepter", new List<List<int>>() }, // Sandstream Scepter
            { "SanguineFlare", new List<List<int>>() }, // Sanguine Flare
            { "SarosPossession", new List<List<int>>() }, // Saros Possession
            { "SausageMaker", new List<List<int>>() }, // Sausage Maker
            { "ScabRipper", new List<List<int>>() }, // Scab Ripper
            { "ScarletDevil", new List<List<int>>() }, // Scarlet Devil
            { "ScorchedEarth", new List<List<int>>() }, // Scorched Earth
            { "Scorpio", new List<List<int>>() }, // Scorpio
            { "ScourgeoftheCosmos", new List<List<int>>() }, // Scourge of the Cosmos
            { "ScourgeoftheDesert", new List<List<int>>() }, // Scourge of the Desert
            { "ScourgeoftheSeas", new List<List<int>>() }, // Scourge of the Seas
            { "SDFMG", new List<List<int>>() }, // SDFMG
            { "SeasSearing", new List<List<int>>() }, // Sea's Searing
            { "Seadragon", new List<List<int>>() }, // Seadragon
            { "SeafoamBomb", new List<List<int>>() }, // Seafoam Bomb
            { "SealedSingularity", new List<List<int>>() }, // Sealed Singularity
            { "SeashineSword", new List<List<int>>() }, // Seashine Sword
            { "SeekingScorcher", new List<List<int>>() }, // Seeking Scorcher
            { "SeethingDischarge", new List<List<int>>() }, // Seething Discharge
            { "SepticSkewer", new List<List<int>>() }, // Septic Skewer
            { "Seraphim", new List<List<int>>() }, // Seraphim
            { "Serpentine", new List<List<int>>() }, // Serpentine
            { "ShadecrystalBarrage", new List<List<int>>() }, // Shadecrystal Barrage
            { "ShaderainStaff", new List<List<int>>() }, // Shaderain Staff
            { "Shadethrower", new List<List<int>>() }, // Shadethrower
            { "ShadowboltStaff", new List<List<int>>() }, // Shadowbolt Staff
            { "ShardofAntumbra", new List<List<int>>() }, // Shard of Antumbra
            { "ShatteredDawn", new List<List<int>>() }, // Shattered Dawn
            { "ShellfishStaff", new List<List<int>>() }, // Shellfish Staff
            { "Shellshooter", new List<List<int>>() }, // Shellshooter
            { "ShiftingSands", new List<List<int>>() }, // Shifting Sands
            { "Shimmerspark", new List<List<int>>() }, // Shimmerspark
            { "ShinobiBlade", new List<List<int>>() }, // Shinobi Blade
            { "SHPC", new List<List<int>>() }, // SHPC
            { "Shredder", new List<List<int>>() }, // Shredder
            { "Shroomer", new List<List<int>>() }, // Shroomer
            { "Sirius", new List<List<int>>() }, // Sirius
            { "SkyGlaze", new List<List<int>>() }, // Sky Glaze
            { "SkyfinBombers", new List<List<int>>() }, // Skyfin Bombers
            { "Skynamite", new List<List<int>>() }, // Skynamite
            { "SkytideDragoon", new List<List<int>>() }, // Skytide Dragoon
            { "SlagMagnum", new List<List<int>>() }, // Slag Magnum
            { "SlagfireDouser", new List<List<int>>() }, // Slagfire Douser
            { "SlickCane", new List<List<int>>() }, // Slick Cane
            { "SlimePuppetStaff", new List<List<int>>() }, // Slime Puppet Staff
            { "SlitheringEels", new List<List<int>>() }, // Slithering Eels
            { "SludgeSplotch", new List<List<int>>() }, // Sludge Splotch
            { "SmokingComet", new List<List<int>>() }, // Smoking Comet
            { "SnakeEyes", new List<List<int>>() }, // Snake Eyes
            { "SnapClam", new List<List<int>>() }, // Snap Clam
            { "SnowstormStaff", new List<List<int>>() }, // Snowstorm Staff
            { "SolsticeClaymore", new List<List<int>>() }, // Solstice Claymore
            { "SomaPrime", new List<List<int>>() }, // Soma Prime
            { "SoulHarvester", new List<List<int>>() }, // Soul Harvester
            { "SoulPiercer", new List<List<int>>() }, // Soul Piercer
            { "SparkSpreader", new List<List<int>>() }, // Spark Spreader
            { "SpearofDestiny", new List<List<int>>() }, // Spear of Destiny
            { "SpearofPaleolith", new List<List<int>>() }, // Spear of Paleolith
            { "SpectralstormCannon", new List<List<int>>() }, // Spectralstorm Cannon
            { "SpeedBlaster", new List<List<int>>() }, // Speed Blaster
            { "SpentFuelContainer", new List<List<int>>() }, // Spent Fuel Container
            { "SpikecragStaff", new List<List<int>>() }, // Spikecrag Staff
            { "SpineOfThanatos", new List<List<int>>() }, // Spine of Thanatos
            { "SporeKnife", new List<List<int>>() }, // Spore Knife
            { "Spyker", new List<List<int>>() }, // Spyker
            { "SquirrelSquireStaff", new List<List<int>>() }, // Squirrel Squire Staff
            { "StaffofBlushie", new List<List<int>>() }, // Staff of Blushie
            { "StaffOfNecrosteocytes", new List<List<int>>() }, // Staff of Necrosteocytes
            { "StarofDestruction", new List<List<int>>() }, // Star of Destruction
            { "StarShower", new List<List<int>>() }, // Star Shower
            { "StarSputter", new List<List<int>>() }, // Star Sputter
            { "StarStruckWater", new List<List<int>>() }, // Star Struck Water
            { "Starfleet", new List<List<int>>() }, // Starfleet
            { "Starmada", new List<List<int>>() }, // Starmada
            { "Starmageddon", new List<List<int>>() }, // Starmageddon
            { "StarnightLance", new List<List<int>>() }, // Starnight Lance
            { "StarspawnHelixStaff", new List<List<int>>() }, // Starspawn Helix Staff
            { "StellarCannon", new List<List<int>>() }, // Stellar Cannon
            { "StellarContempt", new List<List<int>>() }, // Stellar Contempt
            { "StellarKnife", new List<List<int>>() }, // Stellar Knife
            { "StellarStriker", new List<List<int>>() }, // Stellar Striker
            { "StellarTorusStaff", new List<List<int>>() }, // Stellar Torus Staff
            { "StormRuler", new List<List<int>>() }, // Storm Ruler
            { "StormSaber", new List<List<int>>() }, // Storm Saber
            { "StormSurge", new List<List<int>>() }, // Storm Surge
            { "StormfrontRazor", new List<List<int>>() }, // Stormfront Razor
            { "StormjawStaff", new List<List<int>>() }, // Stormjaw Staff
            { "StratusSphere", new List<List<int>>() }, // Stratus Sphere
            { "StreamGouge", new List<List<int>>() }, // Stream Gouge
            { "StygianShield", new List<List<int>>() }, // Stygian Shield
            { "SubductionSlicer", new List<List<int>>() }, // Subduction Slicer
            { "SubmarineShocker", new List<List<int>>() }, // Submarine Shocker
            { "SubsumingVortex", new List<List<int>>() }, // Subsuming Vortex
            { "SulphuricAcidCannon", new List<List<int>>() }, // Sulphuric Acid Cannon
            { "SulphurousGrabber", new List<List<int>>() }, // Sulphurous Grabber
            { "SunSpiritStaff", new List<List<int>>() }, // Sun Spirit Staff
            { "Supernova", new List<List<int>>() }, // Supernova
            { "SuperradiantSlaughterer", new List<List<int>>() }, // Superradiant Slaughterer
            { "SurgeDriver", new List<List<int>>() }, // Surge Driver
            { "Svantechnical", new List<List<int>>() }, // Svantechnical
            { "Swordsplosion", new List<List<int>>() }, // Swordsplosion
            { "Sylvestaff", new List<List<int>>() }, // Sylvestaff
            { "SystemBane", new List<List<int>>() }, // System Bane
            { "TacticalPlagueEngine", new List<List<int>>() }, // Tactical Plague Engine
            { "TacticiansTrumpCard", new List<List<int>>() }, // Tactician's Trump Card
            { "TaintedBlade", new List<List<int>>() }, // Tainted Blade
            { "TarragonThrowingDart", new List<List<int>>() }, // Tarragon Throwing Dart
            { "TauCannon", new List<List<int>>() }, // Tau Cannon
            { "TeardropCleaver", new List<List<int>>() }, // Teardrop Cleaver
            { "TearsofHeaven", new List<List<int>>() }, // Tears of Heaven
            { "TelluricGlare", new List<List<int>>() }, // Telluric Glare
            { "TemporalUmbrella", new List<List<int>>() }, // Temporal Umbrella
            { "TenebreusTides", new List<List<int>>() }, // Tenebreus Tides
            { "Terratomere", new List<List<int>>() }, // Terratomere
            { "TerrorBlade", new List<List<int>>() }, // Terror Blade
            { "TerrorTalons", new List<List<int>>() }, // Terror Talons
            { "TeslaCannon", new List<List<int>>() }, // Tesla Cannon
            { "Teslastaff", new List<List<int>>() }, // Teslastaff
            { "TheAnomalysNanogun", new List<List<int>>() }, // The Anomaly's Nanogun
            { "TheAtomSplitter", new List<List<int>>() }, // The Atom Splitter
            { "TheBallista", new List<List<int>>() }, // The Ballista
            { "TheBurningSky", new List<List<int>>() }, // The Burning Sky
            { "TheCauldron", new List<List<int>>() }, // The Cauldron
            { "TheDanceofLight", new List<List<int>>() }, // The Dance of Light
            { "TheDarkMaster", new List<List<int>>() }, // The Dark Master
            { "TheFinalDawn", new List<List<int>>() }, // The Final Dawn
            { "TheGodsGambit", new List<List<int>>() }, // The God's Gambit
            { "TheHive", new List<List<int>>() }, // The Hive
            { "TheJailor", new List<List<int>>() }, // The Jailor
            { "TheLastMourning", new List<List<int>>() }, // The Last Mourning
            { "TheMaelstrom", new List<List<int>>() }, // The Maelstrom
            { "TheMicrowave", new List<List<int>>() }, // The Microwave
            { "TheMutilator", new List<List<int>>() }, // The Mutilator
            { "TheObliterator", new List<List<int>>() }, // The Obliterator
            { "TheOldReaper", new List<List<int>>() }, // The Old Reaper
            { "TheOracle", new List<List<int>>() }, // The Oracle
            { "ThePack", new List<List<int>>() }, // The Pack
            { "ThePrince", new List<List<int>>() }, // The Prince
            { "TheSevensStriker", new List<List<int>>() }, // The Sevens Striker
            { "TheStorm", new List<List<int>>() }, // The Storm
            { "TheSwarmer", new List<List<int>>() }, // The Swarmer
            { "TheSyringe", new List<List<int>>() }, // The Syringe
            { "TheWand", new List<List<int>>() }, // The Wand
            { "ThermoclineBlaster", new List<List<int>>() }, // Thermocline Blaster
            { "ThornBlossom", new List<List<int>>() }, // Thorn Blossom
            { "ThreadOfEradication", new List<List<int>>() }, // Thread of Eradication
            { "ThrowingBrick", new List<List<int>>() }, // Throwing Brick
            { "TimeBolt", new List<List<int>>() }, // Time Bolt
            { "TitanArm", new List<List<int>>() }, // Titan Arm
            { "TitaniumRailgun", new List<List<int>>() }, // Titanium Railgun
            { "TitaniumShuriken", new List<List<int>>() }, // Titanium Shuriken
            { "ToothBall", new List<List<int>>() }, // Tooth Ball
            { "TotalityBreakers", new List<List<int>>() }, // Totality Breakers
            { "Toxibow", new List<List<int>>() }, // Toxibow
            { "ToxicantTwister", new List<List<int>>() }, // Toxicant Twister
            { "Tradewinds", new List<List<int>>() }, // Tradewinds
            { "TriactisTruePaladinianMageHammerofMight", new List<List<int>>() }, // Triactis' True Paladinian Mage-Hammer of Might
            { "OmegaBiomeBlade", new List<List<int>>() }, // True Biome Blade
            { "Tumbleweed", new List<List<int>>() }, // Tumbleweed
            { "TundraFlameBlossomsStaff", new List<List<int>>() }, // Tundra Flame Blossoms Staff
            { "Turbulance", new List<List<int>>() }, // Turbulance
            { "TwistingThunder", new List<List<int>>() }, // Twisting Thunder
            { "TyphonsGreed", new List<List<int>>() }, // Typhon's Greed
            { "TyrannysEnd", new List<List<int>>() }, // Tyranny's End
            { "Ultima", new List<List<int>>() }, // Ultima
            { "UltimusCleaver", new List<List<int>>() }, // Ultimus Cleaver
            { "UltraLiquidator", new List<List<int>>() }, // Ultra Liquidator
            { "UndinesRetribution", new List<List<int>>() }, // Undine's Retribution
            { "UniversalGenesis", new List<List<int>>() }, // Universal Genesis
            { "UniverseSplitter", new List<List<int>>() }, // Universe Splitter
            { "UnstableCastersGauntlet", new List<List<int>>() }, // Unstable Caster's Gauntlet
            { "UrchinMace", new List<List<int>>() }, // Urchin Mace
            { "UrchinStinger", new List<List<int>>() }, // Urchin Stinger
            { "UtensilPoker", new List<List<int>>() }, // Utensil Poker
            { "Valediction", new List<List<int>>() }, // Valediction
            { "ValkyrieRay", new List<List<int>>() }, // Valkyrie Ray
            { "VanishingPoint", new List<List<int>>() }, // Vanishing Point
            { "VeeringWind", new List<List<int>>() }, // Veering Wind
            { "Vega", new List<List<int>>() }, // Vega
            { "Vehemence", new List<List<int>>() }, // Vehemence
            { "VeinBurster", new List<List<int>>() }, // Vein Burster
            { "VengefulSunStaff", new List<List<int>>() }, // Vengeful Sun Staff
            { "VenusianTrident", new List<List<int>>() }, // Venusian Trident
            { "VernalBolter", new List<List<int>>() }, // Vernal Bolter
            { "Vesuvius", new List<List<int>>() }, // Vesuvius
            { "Vigilance", new List<List<int>>() }, // Vigilance
            { "VileFeeder", new List<List<int>>() }, // Vile Feeder
            { "Violence", new List<List<int>>() }, // Violence
            { "ViralSprout", new List<List<int>>() }, // Viral Sprout
            { "ViridVanguard", new List<List<int>>() }, // Virid Vanguard
            { "Virulence", new List<List<int>>() }, // Virulence
            { "Viscera", new List<List<int>>() }, // Viscera
            { "VitriolicViper", new List<List<int>>() }, // Vitriolic Viper
            { "VividClarity", new List<List<int>>() }, // Vivid Clarity
            { "VoidConcentrationStaff", new List<List<int>>() }, // Void Concentration Staff
            { "VoidEaterMarionette", new List<List<int>>() }, // Void Eater Marionette
            { "VoidEdge", new List<List<int>>() }, // Void Edge
            { "VoidVortex", new List<List<int>>() }, // Void Vortex
            { "Voidragon", new List<List<int>>() }, // Voidragon
            { "VoltaicClimax", new List<List<int>>() }, // Voltaic Climax
            { "Volterion", new List<List<int>>() }, // Volterion
            { "Vortexpopper", new List<List<int>>() }, // Vortexpopper
            { "VulcaniteLance", new List<List<int>>() }, // Vulcanite Lance
            { "PhalanxSurge", new List<List<int>>() }, // W-LSR: Phalanx Surge
            { "WarloksMoonFist", new List<List<int>>() }, // Warloks' Moon Fist
            { "WavePounder", new List<List<int>>() }, // Wave Pounder
            { "WaveSkipper", new List<List<int>>() }, // Wave Skipper
            { "Waywasher", new List<List<int>>() }, // Waywasher
            { "WebBall", new List<List<int>>() }, // Web Ball
            { "Whitewater", new List<List<int>>() }, // Whitewater
            { "WildfireBloom", new List<List<int>>() }, // Wildfire Bloom
            { "WindBlade", new List<List<int>>() }, // Wind Blade
            { "Wingman", new List<List<int>>() }, // Wingman
            { "WintersFury", new List<List<int>>() }, // Winter's Fury
            { "WitherBlossomsStaff", new List<List<int>>() }, // Wither Blossoms Staff
            { "Wrathwing", new List<List<int>>() }, // Wrathwing
            { "WulfrumBlunderbuss", new List<List<int>>() }, // Wulfrum Blunderbuss
            { "WulfrumController", new List<List<int>>() }, // Wulfrum Controller
            { "WulfrumKnife", new List<List<int>>() }, // Wulfrum Knife
            { "WulfrumProsthesis", new List<List<int>>() }, // Wulfrum Prosthesis
            { "WulfrumScrewdriver", new List<List<int>>() }, // Wulfrum Screwdriver
            { "WyvernsCall", new List<List<int>>() }, // Wyvern's Call
            { "YateveoBloom", new List<List<int>>() }, // Yateveo Bloom
            { "YharimsCrystal", new List<List<int>>() }, // Yharim's Crystal
            { "YharonsKindleStaff", new List<List<int>>() }, // Yharon's Kindle Staff
            { "YinYo", new List<List<int>>() }, // Yin-Yo
        };
    }
} 
