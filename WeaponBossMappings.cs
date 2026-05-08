using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.Providence;
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

        public static readonly Dictionary<int, List<List<int>>> Mapping = new()
        {
            // new List<List<int>>
            //    {
            //        new() { BossID.x },
            //        new() { BossID.y, BossID.a },
            //        new() { BossID.b }
            //    }
            // leave new list empty if pre boss

            { 7523 , new List<List<int>>{ // A-PLS: Pulse Rifle
                    new() {ModContent.NPCType<DevourerofGodsHead>() }
            } },  
            { 8141, new List<List<int>>{ // Abandoned Slime Staff
                    new() {ModContent.NPCType<AstrumAureus>() },
            } }, 
            { 7672, new List<List<int>>{ // Absolute Zero
                    new() {NPCID.Plantera},
            } }, 
            { 7673, new List<List<int>>{ // Abyss Blade
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } }, 
            { 7533, new List<List<int>>{ // Abyss Shocker
                    new() {NPCID.SkeletronHead},
            } }, 
            { 7532, new List<List<int>>{ // Abyssal Tome 
                    new() {ModContent.NPCType<SlimeGodCore>()}
            } }, 
            { 7534, new List<List<int>>{ // Acid Gun
                    new() {NPCID.EyeofCthulhu},
                    new() {NPCID.WallofFlesh} 
            } }, 
            { 7840, new List<List<int>>{ // Ace's High
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { 7841, new List<List<int>>() }, // Acidwood Bow
            { 7674, new List<List<int>>() }, // Acidwood Sword
            { 7842, new List<List<int>>{ // Adamantite Particle Accelerator
                    new() {NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism},
                    new() {NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime},
                    new() {NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { 8000, new List<List<int>>{ // Adamantite Throwing Axe
                    new() {NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism},
                    new() {NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime},
                    new() {NPCID.SkeletronPrime, NPCID.TheDestroyer}
            } }, 
            { 7675, new List<List<int>>{ // Aegis Blade
                    new() {NPCID.Golem}
            } }, 
            { 8239, new List<List<int>>{ // Aestheticus
                    new() {ModContent.NPCType<HiveMind>() },
                    new() {ModContent.NPCType<PerforatorHive>() }
            } }, 
            { 7536, new List<List<int>>{ // Aether's Whisper
                    new() {ModContent.NPCType<Signus>() }
            } }, 
            { 7535, new List<List<int>>{ // Aetherflux Cannon
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { 7676, new List<List<int>>{ // Air Spinner
                    new() {ModContent.NPCType<HiveMind>() },
                    new() {ModContent.NPCType<PerforatorHive>() }
            } }, 
            { 7843, new List<List<int>>{ // Alluvion
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { 7537, new List<List<int>>{ // Alpha Draconis
                    new() {ModContent.NPCType<Polterghast>()}
            } }, 
            { 7538, new List<List<int>>{ // Alula Australis
                    new() {ModContent.NPCType<AstrumAureus>()}
            } }, 
            { 7677, new List<List<int>>{ // Amidias' Trident
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { 8142, new List<List<int>>{ // Amphibian's Guitar
                    new() {NPCID.Plantera}
            } }, 
            { 7539, new List<List<int>>{ // Anahita's Arpeggio
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } }, 
            { 7678, new List<List<int>>{ // Anarchy Blade
                    new() {NPCID.Plantera}
            } }, 
            { 8143, new List<List<int>>{ // Ancient Ice Chunk
                    new() {NPCID.WallofFlesh}
            } }, 
            { 7844, new List<List<int>>{ // Angelic Shotgun
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { 7845, new List<List<int>>{ // Animosity
                    new() {ModContent.NPCType<CalamitasClone>()}
            } }, 
            { 7846, new List<List<int>>{ // Anti-materiel Rifle
                    new() {ModContent.NPCType<DevourerofGodsHead>()}
            } }, 
            { 8001, new List<List<int>>() }, // Antlion Skewer
            { 7679, new List<List<int>>{ // Aorta
                    new() {ModContent.NPCType<PerforatorHive>()}
            } }, 
            { 7540, new List<List<int>>{ // Apathanull
                    new() {NPCID.CultistBoss},
            } }, 
            { 8002, new List<List<int>>{ // Apoctolith
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()},
            } }, 
            { 7541, new List<List<int>>{ // Apoctosis Array
                    new() {NPCID.CultistBoss}
            } }, 
            { 7542, new List<List<int>>{ // Apotheosis
                    new() {ModContent.NPCType<SupremeCalamitas>()}
            } }, 
            { 8144, new List<List<int>>{ // Aqua's Scepter
                    new() {ModContent.NPCType<StormWeaverHead>()}
            } },
            { 7543, new List<List<int>>{ // Aquamarine Staff
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { 7847, new List<List<int>>{ // Aquashard Shotgun
                    new() {ModContent.NPCType<HiveMind>()},
                    new() {ModContent.NPCType<PerforatorHive>()}
            } }, 
            { 7848, new List<List<int>>{ // Arbalest
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer},
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime}
            } }, 
            { 7850, new List<List<int>>{ // Arc Nova Diffuser
                    new() {ModContent.NPCType<CalamitasClone>()}
            } }, 
            { 7544, new List<List<int>>{ // Arch Amaryllis
                    new() {NPCID.CultistBoss}
            } }, 
            { 7849, new List<List<int>>{ // Archerfish
                    new() {NPCID.SkeletronHead}
            } }, 
            { 7545, new List<List<int>>{ // Arctic Bear Paw
                    new() {NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer, NPCID.SkeletronPrime}
            } }, 
            { 8145, new List<List<int>>{ // Ares' Exoskeleton
                    new() {ModContent.NPCType<Apollo>()}
            } },
            { 7851, new List<List<int>>{ // Arietes 41
                    new() {NPCID.Plantera}
            } }, 
            { 7823, new List<List<int>>{ // Ark of the Ancients
                    new() {NPCID.Plantera}
            } }, 
            { 7680, new List<List<int>>{ // Ark of the Cosmos
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { 7681, new List<List<int>>{ // Ark of the Elements
                    new() {NPCID.MoonLordCore}
            } }, 
            { 7546, new List<List<int>>{ // Art Attack
                    new() {ModContent.NPCType<CalamitasClone>()}
            } }, 
            { 7852, new List<List<int>>{ // Arterial Assault
                    new() {ModContent.NPCType<Providence>()},
            } }, 
            { 8003, new List<List<int>>() }, // Ashen Stalactite
            { 7853, new List<List<int>>{ // Astral Blaster
                    new() {ModContent.NPCType<AstrumDeusHead>(), NPCID.CultistBoss}
            } }, 
            { 7682, new List<List<int>>{ // Astral Pike
                    new() {ModContent.NPCType<AstrumDeusHead>(), NPCID.CultistBoss}
            } }, 
            { 7683, new List<List<int>>{ // Astral Scythe
                    new() {ModContent.NPCType<AstrumAureus>()}
            } }, 
            { 7548, new List<List<int>>{ // Astral Staff
                    new() {ModContent.NPCType<AstrumDeusHead>(), NPCID.CultistBoss}
            } }, 
            { 7547, new List<List<int>>{ // Astralachnea Staff
                    new() {ModContent.NPCType<AstrumAureus>()}
            } }, 
            { 7854, new List<List<int>>{ // Astreal Defeat
                    new() {NPCID.MoonLordCore}
            } }, 
            { 7684, new List<List<int>>{ // Ataraxia
                    new() {ModContent.NPCType<Yharon>()}
            } }, 
            { 7549, new List<List<int>>{ // Atlantis
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } }, 
            { 8146, new List<List<int>>{ // Atlas Munitions Beacon
                    new() {ModContent.NPCType<Apollo>()}
            } }, 
            { 7550, new List<List<int>>{ // Augur of the Void
                    new() {NPCID.MoonLordCore}
            } }, 
            { 7855, new List<List<int>>{ // Auralis
                    new() {ModContent.NPCType<Providence>()}
            } }, 
            { 7856, new List<List<int>>{ // Aurora Blazer
                    new() {ModContent.NPCType<AstrumAureus>()}
            } }, 
            { 8004, new List<List<int>>{ // Auroradical Throw
                    new() {ModContent.NPCType<AstrumAureus>()}
            } }, 
            { 7685, new List<List<int>>{ // Avalanche
                    new() {ModContent.NPCType<Cryogen>()}
            } }, 
            { 7514, new List<List<int>>{ // B-GSS: Nidhogg
                    new() {ModContent.NPCType<PlaguebringerGoliath>()}
            } }, 
            { 7509, new List<List<int>>{ // B-LSR: Countermeasure Mitt
                    new() {ModContent.NPCType<PlaguebringerGoliath>()}
            } },
            { 7686, new List<List<int>>{ // Baleful Harvester
                    new() {NPCID.CultistBoss}
            } }, 
            { 7687, new List<List<int>>{ // Ball O' Fugu
                    new() {NPCID.SkeletronHead}
            } }, 
            { 8005, new List<List<int>>{ // Ballistic Poison Bomb
                    new() {ModContent.NPCType<Anahita>(), ModContent.NPCType<Leviathan>()}
            } }, 
            { 7688, new List<List<int>>{ // Banshee Hook
                    new() {ModContent.NPCType<Polterghast>()}
            } }, 
            { 7857, new List<List<int>>{ // Barinade
                    new() {ModContent.NPCType<DesertScourgeHead>()}
            } }, 
            { 7858, new List<List<int>>{ // Barinautical
                    new() {ModContent.NPCType<AquaticScourgeHead>()}
            } }, 
            { 7859, new List<List<int>>{ // Barracuda Gun
                    new() {NPCID.MoonLordCore}
            } }, 
            { 7689, new List<List<int>>{ // Basher
                    new() {NPCID.EyeofCthulhu},
                    new() {NPCID.WallofFlesh}
            } }, 
            { 7551, new List<List<int>>() }, // Belching Saxophone
            { 8147, new List<List<int>>() }, // Belladonna Spirit Staff
            { 7552, new List<List<int>>() }, // Biofusillade
            { 7824, new List<List<int>>() }, // Biome Blade
            { 7553, new List<List<int>>() }, // Black Anurian
            { 8148, new List<List<int>>() }, // Black Hawk Remote
            { 7690, new List<List<int>>() }, // Bladecrest Oathsword
            { 7860, new List<List<int>>() }, // Bladedge Railbow
            { 8006, new List<List<int>>() }, // Blast Barrel
            { 8007, new List<List<int>>() }, // Blazing Star
            { 7861, new List<List<int>>() }, // Blight Spewer
            { 7691, new List<List<int>>() }, // Blighted Cleaver
            { 7862, new List<List<int>>() }, // Blissful Bombardier
            { 7554, new List<List<int>>() }, // Blood Bath
            { 7863, new List<List<int>>() }, // Blood Boiler
            { 8008, new List<List<int>>() }, // Bloodsoaked Crasher
            { 7864, new List<List<int>>() }, // Blossom Flux
            { 7692, new List<List<int>>() }, // Bonebreaker
            { 8149, new List<List<int>>() }, // Borealis Bomber
            { 7693, new List<List<int>>() }, // Botanic Piercer
            { 8009, new List<List<int>>() }, // Bouncing Eyeball
            { 8010, new List<List<int>>() }, // Brimblade
            { 7694, new List<List<int>>() }, // Brimlance
            { 7695, new List<List<int>>() }, // Brimlash
            { 7555, new List<List<int>>() }, // Brimrose Staff
            { 7865, new List<List<int>>() }, // Brimstone Fury
            { 7696, new List<List<int>>() }, // Brimstone Sword
            { 7697, new List<List<int>>() }, // Briny Baron
            { 8150, new List<List<int>>() }, // Brittle Star Staff
            { 7698, new List<List<int>>{ // Broken Biome Blade
                    new() {ModContent.NPCType<HiveMind>() },
                    new() {ModContent.NPCType<PerforatorHive>() }
            } }, 
            { 7866, new List<List<int>>() }, // Bullet-Filled Shotgun
            { 7699, new List<List<int>>() }, // Burning Revelation
            { 7556, new List<List<int>>() }, // Burning Sea
            { 8011, new List<List<int>>() }, // Burning Strife
            { 7700, new List<List<int>>() }, // Burnt Sienna
            { 7867, new List<List<int>>() }, // Buzzkill
            { 8151, new List<List<int>>() }, // Cadaverous Carrion
            { 8152, new List<List<int>>() }, // Calamari's Lament
            { 7701, new List<List<int>>() }, // Carnage
            { 8153, new List<List<int>>() }, // Caustic Croaker Staff
            { 7825, new List<List<int>>() }, // Caustic Edge
            { 8154, new List<List<int>>() }, // Caustic Staff
            { 7702, new List<List<int>>() }, // Celestial Claymore
            { 8012, new List<List<int>>() }, // Celestial Reaper
            { 8013, new List<List<int>>() }, // Celestus
            { 7868, new List<List<int>>() }, // Chicken Cannon
            { 7869, new List<List<int>>() }, // Chromatic Eruption
            { 7557, new List<List<int>>() }, // Chronomancer's Scythe
            { 8155, new List<List<int>>() }, // Cinder Blossom Staff
            { 8156, new List<List<int>>() }, // Cinders of Lament
            { 8014, new List<List<int>>() }, // Cinquedea
            { 7703, new List<List<int>>() }, // Clam Crusher
            { 7870, new List<List<int>>() }, // Clamor Rifle
            { 8240, new List<List<int>>() }, // Claret Cannon
            { 7871, new List<List<int>>() }, // Cleansing Blaze
            { 7872, new List<List<int>>() }, // Clockwork Bow
            { 7558, new List<List<int>>() }, // Clothier's Wrath
            { 8157, new List<List<int>>() }, // Cnidarian
            { 8015, new List<List<int>>() }, // Cobalt Kunai
            { 8241, new List<List<int>>() }, // Coldheart Icicle
            { 7704, new List<List<int>>() }, // Comet Quasher
            { 7873, new List<List<int>>() }, // Condemnation
            { 7874, new List<List<int>>() }, // Conference Call
            { 8016, new List<List<int>>() }, // Consecrated Water
            { 7875, new List<List<int>>() }, // Contagion
            { 8017, new List<List<int>>() }, // Contaminated Bile
            { 7876, new List<List<int>>() }, // Continental Greatbow
            { 7559, new List<List<int>>() }, // Coral Spout
            { 7877, new List<List<int>>() }, // Corinth Prime
            { 8018, new List<List<int>>() }, // Corpus Avertor
            { 7878, new List<List<int>>() }, // Corroded Caustibow
            { 8158, new List<List<int>>() }, // Corroslime Staff
            { 8159, new List<List<int>>() }, // Corvid Harbinger Staff
            { 7705, new List<List<int>>() }, // Cosmic Discharge
            { 8160, new List<List<int>>() }, // Cosmic Immaterializer
            { 8019, new List<List<int>>() }, // Cosmic Kunai
            { 7560, new List<List<int>>() }, // Cosmic Rainbow
            { 7706, new List<List<int>>() }, // Cosmic Shiv
            { 8161, new List<List<int>>() }, // Cosmic Viper Engine
            { 8162, new List<List<int>>() }, // Cosmilamp
            { 7879, new List<List<int>>() }, // Crackshot Colt
            { 8020, new List<List<int>>() }, // Cranium Smasher
            { 7707, new List<List<int>>() }, // Crescent Moon
            { 8163, new List<List<int>>() }, // Crimslime Staff
            { 8021, new List<List<int>>() }, // Crushsaw Crasher
            { 8164, new List<List<int>>() }, // Cryogenic Staff
            { 7561, new List<List<int>>() }, // Cryophobia
            { 8023, new List<List<int>>() }, // Crystal Piercer
            { 8022, new List<List<int>>() }, // Crystalline
            { 8024, new List<List<int>>() }, // Cursed Dagger
            { 8165, new List<List<int>>() }, // Daedalus Golem Staff
            { 7880, new List<List<int>>() }, // Daemon's Flame
            { 8166, new List<List<int>>() }, // Dank Staff
            { 7562, new List<List<int>>() }, // Dark Spark
            { 7881, new List<List<int>>() }, // Darkecho Greatbow
            { 7708, new List<List<int>>() }, // Darklight Greatsword
            { 8167, new List<List<int>>() }, // Dazzling Stabber Staff
            { 7882, new List<List<int>>() }, // Dead Sun's Wind
            { 7563, new List<List<int>>() }, // Death Valley Duster
            { 7709, new List<List<int>>() }, // Death's Ascension
            { 8168, new List<List<int>>() }, // Deathstare Rod
            { 8025, new List<List<int>>() }, // Deep Sea Dumbbell
            { 8026, new List<List<int>>() }, // Deep Wounder
            { 7883, new List<List<int>>() }, // Deepcore GK2
            { 8169, new List<List<int>>() }, // Deepsea Staff
            { 8027, new List<List<int>>() }, // Defective Sphere
            { 7710, new List<List<int>>() }, // Defiled Greatsword
            { 7711, new List<List<int>>() }, // Depth Crusher
            { 8028, new List<List<int>>() }, // Desecrated Water
            { 7712, new List<List<int>>() }, // Devil's Devastation
            { 7713, new List<List<int>>() }, // Devil's Sunrise
            { 8029, new List<List<int>>() }, // Dimension-Tearing Disk
            { 8030, new List<List<int>>() }, // Doomsday Device
            { 8170, new List<List<int>>() }, // Dormant Brimseeker
            { 7564, new List<List<int>>() }, // Downpour
            { 7714, new List<List<int>>() }, // Draconic Destruction
            { 7715, new List<List<int>>() }, // Dragon Pow
            { 7716, new List<List<int>>() }, // Dragon Rage
            { 7884, new List<List<int>>() }, // Dragon's Breath
            { 8171, new List<List<int>>() }, // Dragonblood Disgorger
            { 7885, new List<List<int>>() }, // Drataliornus
            { 8172, new List<List<int>>() }, // Dreadmine Staff
            { 7886, new List<List<int>>() }, // Driftwood Bow
            { 7717, new List<List<int>>() }, // Driftwood Sword
            { 8031, new List<List<int>>() }, // Duke's Decapitator
            { 8032, new List<List<int>>() }, // Duststorm in a Bottle
            { 8033, new List<List<int>>() }, // Dynamic Pursuer
            { 7718, new List<List<int>>() }, // Earth
            { 7719, new List<List<int>>() }, // Earthen Pike
            { 8034, new List<List<int>>() }, // Eclipse's Fall
            { 7565, new List<List<int>>() }, // Effervescence
            { 7566, new List<List<int>>() }, // Eidolic Wail
            { 7567, new List<List<int>>() }, // Eidolon Staff
            { 7568, new List<List<int>>() }, // Eldritch Tome
            { 7720, new List<List<int>>() }, // Empyrean Knives
            { 8035, new List<List<int>>() }, // Enchanted Axe
            { 8173, new List<List<int>>() }, // Enchanted Conch
            { 8174, new List<List<int>>() }, // Enchanted Knife Staff
            { 8176, new List<List<int>>() }, // Endo Hydra Staff
            { 8175, new List<List<int>>() }, // Endogenesis
            { 7721, new List<List<int>>() }, // Entropic Claymore
            { 8177, new List<List<int>>() }, // Entropy's Vigil
            { 8036, new List<List<int>>() }, // Epidemic Shredder
            { 8037, new List<List<int>>() }, // Equanimity
            { 7722, new List<List<int>>() }, // Essence Flayer
            { 7887, new List<List<int>>() }, // Eternal Blizzard
            { 7569, new List<List<int>>() }, // Eternity
            { 8178, new List<List<int>>() }, // Ethereal Subjugator
            { 7570, new List<List<int>>() }, // Event Horizon
            { 7571, new List<List<int>>() }, // Everglade Spray
            { 7723, new List<List<int>>() }, // Evil Smasher
            { 7888, new List<List<int>>() }, // Eviscerator
            { 7724, new List<List<int>>() }, // Exalted Oathblade
            { 8038, new List<List<int>>() }, // Executioner's Blade
            { 7725, new List<List<int>>() }, // Exoblade
            { 8039, new List<List<int>>() }, // Exorcism
            { 8242, new List<List<int>>() }, // Eye of Magnus
            { 8179, new List<List<int>>() }, // Eye of Night
            { 7572, new List<List<int>>() }, // Face Melter
            { 7726, new List<List<int>>() }, // Fallen Paladin's Hammer
            { 8040, new List<List<int>>() }, // Fantasy Talisman
            { 7573, new List<List<int>>() }, // Fate's Reveal
            { 7727, new List<List<int>>() }, // Fault Line
            { 8041, new List<List<int>>() }, // Feather Knife
            { 7728, new List<List<int>>() }, // Feralthorn Claymore
            { 7889, new List<List<int>>() }, // Fetid Emesis
            { 7890, new List<List<int>>() }, // Firestorm Cannon
            { 8042, new List<List<int>>() }, // Fishbone Boomerang
            { 7891, new List<List<int>>() }, // Flak Kraken
            { 7892, new List<List<int>>() }, // Flak Toxicannon
            { 8180, new List<List<int>>() }, // Flamsteed Ring
            { 7574, new List<List<int>>() }, // Flare Bolt
            { 7729, new List<List<int>>() }, // Flarefrost Blade
            { 7893, new List<List<int>>() }, // Flarewing Bow
            { 8181, new List<List<int>>() }, // Flesh of Infidelity
            { 7730, new List<List<int>>() }, // Floodtide
            { 8182, new List<List<int>>() }, // Flowers of Mortality
            { 7894, new List<List<int>>() }, // Flurrystorm Cannon
            { 7731, new List<List<int>>() }, // Forbidden Oathblade
            { 7575, new List<List<int>>() }, // Forbidden Sun
            { 8183, new List<List<int>>() }, // Forgotten Apex Wand
            { 7732, new List<List<int>>() }, // Forsaken Saber
            { 7734, new List<List<int>>() }, // Fractured Ark
            { 7895, new List<List<int>>() }, // Freedom Star
            { 7576, new List<List<int>>() }, // Frigidflash Bolt
            { 8184, new List<List<int>>() }, // Frost Blossom Staff
            { 7577, new List<List<int>>() }, // Frost Bolt
            { 7896, new List<List<int>>() }, // Frostbite Blaster
            { 8043, new List<List<int>>() }, // Frostcrush Valari
            { 8044, new List<List<int>>() }, // Frosty Flare
            { 8185, new List<List<int>>() }, // Fuel Cell Bundle
            { 7897, new List<List<int>>() }, // Fungicide
            { 8045, new List<List<int>>() }, // Gacruxian Mollusk
            { 7735, new List<List<int>>() }, // Gael's Greatsword
            { 7736, new List<List<int>>() }, // Galactus Blade
            { 7733, new List<List<int>>() }, // Galaxia
            { 7737, new List<List<int>>() }, // Galaxy Smasher
            { 7898, new List<List<int>>() }, // Galeforce
            { 7738, new List<List<int>>() }, // Galileo Gladius
            { 7510, new List<List<int>>() }, // Galvanizing Glaive
            { 8186, new List<List<int>>() }, // Gamma Heart
            { 8187, new List<List<int>>() }, // Gastric Belcher Staff
            { 8046, new List<List<int>>() }, // Gel Dart
            { 7739, new List<List<int>>() }, // Gelitic Blade
            { 7578, new List<List<int>>() }, // Genesis
            { 7579, new List<List<int>>() }, // Ghastly Visage
            { 8047, new List<List<int>>() }, // Ghoulish Gouger
            { 8048, new List<List<int>>() }, // Gilded Dagger
            { 7740, new List<List<int>>() }, // Gilded Proboscis
            { 8188, new List<List<int>>() }, // Glacial Embrace
            { 8049, new List<List<int>>() }, // Glaive
            { 8050, new List<List<int>>() }, // Gleaming Dagger
            { 7580, new List<List<int>>() }, // Gleaming Magnolia
            { 7581, new List<List<int>>() }, // Glorious End
            { 8051, new List<List<int>>() }, // Gods' Paranoia
            { 7899, new List<List<int>>() }, // Golden Eagle
            { 7741, new List<List<int>>() }, // Goldplume Spear
            { 7900, new List<List<int>>() }, // Goobow
            { 7742, new List<List<int>>() }, // Grand Dad
            { 7743, new List<List<int>>() }, // Grand Guardian
            { 8052, new List<List<int>>() }, // Grave Grimreaver
            { 7744, new List<List<int>>() }, // Greatsword of Judgement
            { 7745, new List<List<int>>() }, // Greentide
            { 7582, new List<List<int>>() }, // Gruesome Eminence
            { 8189, new List<List<int>>() }, // Guidelight of Oblivion
            { 7901, new List<List<int>>() }, // Gunk Shot
            { 7583, new List<List<int>>() }, // Hadal Urn
            { 7902, new List<List<int>>() }, // Halibut Cannon
            { 7903, new List<List<int>>() }, // Halley's Inferno
            { 7904, new List<List<int>>() }, // Handheld Tank
            { 8053, new List<List<int>>() }, // Hardened Honeycomb
            { 8190, new List<List<int>>() }, // Harvest Staff
            { 8191, new List<List<int>>() }, // Haunted Scroll
            { 7905, new List<List<int>>() }, // Havoc's Breath
            { 8054, new List<List<int>>() }, // Heavenfallen Stardisk
            { 7906, new List<List<int>>() }, // Heavenly Gale
            { 7584, new List<List<int>>() }, // Helium Flash
            { 7907, new List<List<int>>() }, // Hellborn
            { 7746, new List<List<int>>() }, // Hellfire Flamberge
            { 7747, new List<List<int>>() }, // Hellion Flower Spear
            { 7748, new List<List<int>>() }, // Hellkite
            { 7585, new List<List<int>>() }, // Hellwing Staff
            { 7908, new List<List<int>>() }, // Helstorm
            { 7586, new List<List<int>>() }, // Hematemesis
            { 7587, new List<List<int>>() }, // Heresy
            { 8192, new List<List<int>>() }, // Herring Staff
            { 8193, new List<List<int>>() }, // Hive Pod
            { 7909, new List<List<int>>() }, // Hoarfrost Bow
            { 7749, new List<List<int>>() }, // Holy Collider
            { 7910, new List<List<int>>() }, // Hydra
            { 7512, new List<List<int>>() }, // Hydraulic Volt Crasher
            { 7588, new List<List<int>>() }, // Hyperdeath Rift Scepter
            { 7589, new List<List<int>>() }, // Hyphae Rod
            { 8055, new List<List<int>>() }, // Hypothermia
            { 7590, new List<List<int>>() }, // Ice Barrage
            { 8057, new List<List<int>>() }, // Ice Star
            { 8056, new List<List<int>>() }, // Icebreaker
            { 8058, new List<List<int>>() }, // Ichor Spear
            { 7591, new List<List<int>>() }, // Icicle Staff
            { 7592, new List<List<int>>() }, // Icicle Trident
            { 8194, new List<List<int>>() }, // Igneous Exaltation
            { 7750, new List<List<int>>() }, // Illustrious Knives
            { 8195, new List<List<int>>() }, // Infected Remote
            { 8059, new List<List<int>>() }, // Infernal Kris
            { 7593, new List<List<int>>() }, // Infernal Rift
            { 8060, new List<List<int>>() }, // Infested Clawmerang
            { 7911, new List<List<int>>() }, // Infinity
            { 7751, new List<List<int>>() }, // Insidious Impaler
            { 7594, new List<List<int>>() }, // Ion Blaster
            { 8061, new List<List<int>>() }, // Iron Francisca
            { 8062, new List<List<int>>() }, // Jaws of Oblivion
            { 7912, new List<List<int>>() }, // Karasawa
            { 7595, new List<List<int>>() }, // Keelhaul
            { 8063, new List<List<int>>() }, // Kelvin Catalyst
            { 8196, new List<List<int>>() }, // King of Constellations, Tenryū
            { 7913, new List<List<int>>() }, // Kingsbane
            { 8064, new List<List<int>>() }, // Kylie
            { 7752, new List<List<int>>() }, // Lacerator
            { 7596, new List<List<int>>() }, // Lashes of Chaos
            { 8065, new List<List<int>>() }, // Lead Tomahawk
            { 8197, new List<List<int>>() }, // Legion of Celestia
            { 8066, new List<List<int>>() }, // Leonid Progenitor
            { 8067, new List<List<int>>() }, // Leviathan Teeth
            { 7914, new List<List<int>>() }, // Leviatitan
            { 7753, new List<List<int>>() }, // Lifehunt Scythe
            { 7597, new List<List<int>>() }, // Light God's Brilliance
            { 7754, new List<List<int>>() }, // Lightspeed
            { 8198, new List<List<int>>() }, // Lilies of Finality
            { 7755, new List<List<int>>() }, // Lion Heart
            { 8068, new List<List<int>>() }, // Lionfish
            { 7756, new List<List<int>>() }, // Lucrecia
            { 8069, new List<List<int>>() }, // Lunar Kunai
            { 7915, new List<List<int>>() }, // Lunarian Bow
            { 8243, new List<List<int>>() }, // Lunic Eye
            { 7916, new List<List<int>>() }, // M1 Garand
            { 7598, new List<List<int>>() }, // Mad Alchemist's Cocktail Glove
            { 7917, new List<List<int>>() }, // Magna Cannon
            { 7599, new List<List<int>>() }, // Magnetic Meltdown
            { 7918, new List<List<int>>() }, // Magnomaly Cannon
            { 7757, new List<List<int>>() }, // Majestic Guard
            { 8070, new List<List<int>>() }, // Malachite
            { 7919, new List<List<int>>() }, // Malevolence
            { 7600, new List<List<int>>() }, // Mana Rose
            { 8071, new List<List<int>>() }, // Mangrove Chakram
            { 7758, new List<List<int>>() }, // Mantis Claws
            { 7920, new List<List<int>>() }, // Marksman Bow
            { 7759, new List<List<int>>() }, // Maw of Infinity
            { 7921, new List<List<int>>() }, // Megalodon
            { 7922, new List<List<int>>() }, // Meowthrower
            { 8072, new List<List<int>>() }, // Metal Monstrosity
            { 8199, new List<List<int>>() }, // Metastasis
            { 8073, new List<List<int>>() }, // Meteor Fist
            { 7601, new List<List<int>>() }, // Miasma
            { 7923, new List<List<int>>() }, // Midas Prime
            { 8200, new List<List<int>>() }, // Midnight Sun Beacon
            { 7924, new List<List<int>>() }, // Mineral Mortar
            { 7760, new List<List<int>>() }, // Mirror Blade
            { 8201, new List<List<int>>() }, // Mirror of Kalandra
            { 7602, new List<List<int>>() }, // Mistlestorm
            { 8074, new List<List<int>>() }, // Molten Amputator
            { 7925, new List<List<int>>() }, // Monolith Bow
            { 7761, new List<List<int>>() }, // Monolith Sword
            { 7926, new List<List<int>>() }, // Monsoon
            { 7762, new List<List<int>>() }, // Monstrous Knives
            { 7513, new List<List<int>>() }, // Mounted Scanner
            { 7763, new List<List<int>>() }, // Mourningstar
            { 7764, new List<List<int>>() }, // Murasama
            { 8202, new List<List<int>>() }, // Mutated Truffle
            { 7765, new List<List<int>>() }, // Mycelial Claws
            { 8075, new List<List<int>>() }, // Mycoroot
            { 8076, new List<List<int>>() }, // Mythril Knife
            { 7766, new List<List<int>>() }, // Nadir
            { 7603, new List<List<int>>() }, // Nano Purge
            { 8077, new List<List<int>>() }, // Nanoblack Reaper
            { 8078, new List<List<int>>() }, // Nasty Cholla
            { 7767, new List<List<int>>() }, // Nebulash
            { 7604, new List<List<int>>() }, // Nebulous Cataclysm
            { 7927, new List<List<int>>() }, // Needler
            { 7768, new List<List<int>>() }, // Neptune's Bounty
            { 7928, new List<List<int>>() }, // Nettlevine Greatbow
            { 7605, new List<List<int>>() }, // Night's Ray
            { 7929, new List<List<int>>() }, // Nitro Express Rifle
            { 7930, new List<List<int>>() }, // Norfleet
            { 7606, new List<List<int>>() }, // Nuclear Fury
            { 7607, new List<List<int>>() }, // Nucleosynthesis
            { 7931, new List<List<int>>() }, // Nullification Pistol
            { 7769, new List<List<int>>() }, // Oblivion
            { 7770, new List<List<int>>() }, // Old Lord Claymore
            { 7608, new List<List<int>>() }, // Omicron
            { 7772, new List<List<int>>() }, // Omniblade
            { 7932, new List<List<int>>() }, // Ontological Despoiler
            { 7933, new List<List<int>>() }, // Onyx Chain Blaster
            { 7934, new List<List<int>>() }, // Onyxia
            { 7935, new List<List<int>>() }, // Opal Striker
            { 7773, new List<List<int>>() }, // Orderbringer
            { 8079, new List<List<int>>() }, // Orichalcum Spiked Gemstone
            { 8203, new List<List<int>>() }, // Orthocera Shell
            { 7936, new List<List<int>>() }, // Overloaded Blaster
            { 7774, new List<List<int>>() }, // Ozzathoth
            { 7508, new List<List<int>>() }, // P-GSS: Auger
            { 7506, new List<List<int>>() }, // P-LSR: Aerial Tracker
            { 7522, new List<List<int>>() }, // P-PLS: Pulse Pistol
            { 7507, new List<List<int>>() }, // P-PMA: Aqueous Hunter Drone
            { 7525, new List<List<int>>() }, // P-TSL: Short Circuit
            { 7937, new List<List<int>>() }, // P90
            { 8080, new List<List<int>>() }, // Palladium Javelin
            { 7775, new List<List<int>>() }, // Pandemic
            { 7609, new List<List<int>>() }, // Parasitic Scepter
            { 7938, new List<List<int>>() }, // Pearl God
            { 8081, new List<List<int>>() }, // Penumbra
            { 8204, new List<List<int>>() }, // Perdition
            { 7776, new List<List<int>>() }, // Perfect Dark
            { 7939, new List<List<int>>() }, // Pestilent Defiler
            { 7610, new List<List<int>>() }, // Phantasmal Fury
            { 8082, new List<List<int>>() }, // Phantasmal Ruin
            { 7516, new List<List<int>>() }, // Phaseslayer
            { 7611, new List<List<int>>() }, // Phoenix Flame Barrage
            { 7777, new List<List<int>>() }, // Phosphorescent Gauntlet
            { 7778, new List<List<int>>() }, // Photon Ripper
            { 7612, new List<List<int>>() }, // Photosynthesis
            { 7940, new List<List<int>>() }, // Photoviscerator
            { 7613, new List<List<int>>() }, // Plague Staff
            { 7941, new List<List<int>>() }, // Plague Tainted SMG
            { 8083, new List<List<int>>() }, // Plaguenade
            { 7942, new List<List<int>>() }, // Planetary Annihilation
            { 8205, new List<List<int>>() }, // Plantation Staff
            { 7517, new List<List<int>>() }, // Plasma Caster
            { 7518, new List<List<int>>() }, // Plasma Grenade
            { 7614, new List<List<int>>() }, // Plasma Rifle
            { 7615, new List<List<int>>() }, // Plasma Rod
            { 7943, new List<List<int>>() }, // Polaris Parrotfish
            { 7519, new List<List<int>>() }, // Pole Warper
            { 8206, new List<List<int>>() }, // Polyp Launcher
            { 7616, new List<List<int>>() }, // Poseidon
            { 7944, new List<List<int>>() }, // Prideful Hunter's Planar Ripper
            { 7617, new List<List<int>>() }, // Primordial Ancient
            { 7618, new List<List<int>>() }, // Primordial Earth
            { 8084, new List<List<int>>() }, // Prismalline
            { 7779, new List<List<int>>() }, // Prismatic Breaker
            { 7945, new List<List<int>>() }, // Pristine Fury
            { 8085, new List<List<int>>() }, // Profaned Partisan
            { 8207, new List<List<int>>() }, // Puff Shroom
            { 7520, new List<List<int>>() }, // Pulse Dragon
            { 7524, new List<List<int>>() }, // Pulse Turret Remote
            { 8086, new List<List<int>>() }, // Pumpkaboom
            { 7946, new List<List<int>>() }, // Pumpler
            { 7619, new List<List<int>>() }, // Purge Guzzler
            { 7780, new List<List<int>>() }, // Pwnagehammer
            { 7781, new List<List<int>>() }, // Quagmire
            { 7530, new List<List<int>>() }, // R-GSS: Vulcan
            { 7521, new List<List<int>>() }, // R-PLS: Pulse Grenade
            { 7511, new List<List<int>>() }, // R-PMA: Holofibre Immolator
            { 8087, new List<List<int>>() }, // Radiant Star
            { 7620, new List<List<int>>() }, // Rainbow Party Cannon
            { 7621, new List<List<int>>() }, // Rancor
            { 8088, new List<List<int>>() }, // Reality Rupture
            { 7947, new List<List<int>>() }, // Realm Ravager
            { 8089, new List<List<int>>() }, // Rebounding Rainbow
            { 7622, new List<List<int>>() }, // Recitation of the Beast
            { 7782, new List<List<int>>() }, // Red Sun
            { 7948, new List<List<int>>() }, // Reed Blowgun
            { 8090, new List<List<int>>() }, // Refraction Rotor
            { 8091, new List<List<int>>() }, // Regulus Riot
            { 8244, new List<List<int>>() }, // Relic of Deliverance
            { 7623, new List<List<int>>() }, // Relic of Ruin
            { 7783, new List<List<int>>() }, // Rem's Revenge
            { 7784, new List<List<int>>() }, // Respiteblock
            { 8208, new List<List<int>>() }, // Resurrection Butterfly
            { 7949, new List<List<int>>() }, // Riftburst
            { 7785, new List<List<int>>() }, // Riptide
            { 8092, new List<List<int>>() }, // Rot Ball
            { 7624, new List<List<int>>() }, // Rouge Slash
            { 7786, new List<List<int>>() }, // Roxcalibur
            { 7950, new List<List<int>>() }, // Rubico Prime
            { 8209, new List<List<int>>() }, // Rusty Beacon Prototype
            { 8093, new List<List<int>>() }, // Sacrifice
            { 7787, new List<List<int>>() }, // Sahara Slicers
            { 8094, new List<List<int>>() }, // Samsara Slicer
            { 8210, new List<List<int>>() }, // Sanctified Spark
            { 8095, new List<List<int>>() }, // Sand Dollar
            { 8211, new List<List<int>>() }, // Sand Sharknado Staff
            { 7951, new List<List<int>>() }, // Sandblaster
            { 7625, new List<List<int>>() }, // Sandstream Scepter
            { 7626, new List<List<int>>() }, // Sanguine Flare
            { 8212, new List<List<int>>() }, // Saros Possession
            { 7788, new List<List<int>>() }, // Sausage Maker
            { 8213, new List<List<int>>() }, // Scab Ripper
            { 8096, new List<List<int>>() }, // Scarlet Devil
            { 7952, new List<List<int>>() }, // Scorched Earth
            { 7953, new List<List<int>>() }, // Scorpio
            { 7789, new List<List<int>>() }, // Scourge of the Cosmos
            { 8097, new List<List<int>>() }, // Scourge of the Desert
            { 8098, new List<List<int>>() }, // Scourge of the Seas
            { 7954, new List<List<int>>() }, // SDFMG
            { 7956, new List<List<int>>() }, // Sea's Searing
            { 7955, new List<List<int>>() }, // Seadragon
            { 8099, new List<List<int>>() }, // Seafoam Bomb
            { 8100, new List<List<int>>() }, // Sealed Singularity
            { 7790, new List<List<int>>() }, // Seashine Sword
            { 7791, new List<List<int>>() }, // Seeking Scorcher
            { 7627, new List<List<int>>() }, // Seething Discharge
            { 7957, new List<List<int>>() }, // Septic Skewer
            { 8101, new List<List<int>>() }, // Seraphim
            { 7628, new List<List<int>>() }, // Serpentine
            { 7629, new List<List<int>>() }, // Shadecrystal Barrage
            { 7630, new List<List<int>>() }, // Shaderain Staff
            { 7958, new List<List<int>>() }, // Shadethrower
            { 7631, new List<List<int>>() }, // Shadowbolt Staff
            { 8102, new List<List<int>>() }, // Shard of Antumbra
            { 8103, new List<List<int>>() }, // Shattered Dawn
            { 8214, new List<List<int>>() }, // Shellfish Staff
            { 7959, new List<List<int>>() }, // Shellshooter
            { 7632, new List<List<int>>() }, // Shifting Sands
            { 7792, new List<List<int>>() }, // Shimmerspark
            { 8104, new List<List<int>>() }, // Shinobi Blade
            { 7633, new List<List<int>>() }, // SHPC
            { 7960, new List<List<int>>() }, // Shredder
            { 7961, new List<List<int>>() }, // Shroomer
            { 8215, new List<List<int>>() }, // Sirius
            { 7634, new List<List<int>>() }, // Sky Glaze
            { 8105, new List<List<int>>() }, // Skyfin Bombers
            { 8245, new List<List<int>>() }, // Skynamite
            { 7793, new List<List<int>>() }, // Skytide Dragoon
            { 7963, new List<List<int>>() }, // Slag Magnum
            { 7962, new List<List<int>>() }, // Slagfire Douser
            { 8106, new List<List<int>>() }, // Slick Cane
            { 8216, new List<List<int>>() }, // Slime Puppet Staff
            { 7635, new List<List<int>>() }, // Slithering Eels
            { 8107, new List<List<int>>() }, // Sludge Splotch
            { 7794, new List<List<int>>() }, // Smoking Comet
            { 7526, new List<List<int>>() }, // Snake Eyes
            { 8108, new List<List<int>>() }, // Snap Clam
            { 7636, new List<List<int>>() }, // Snowstorm Staff
            { 7795, new List<List<int>>() }, // Solstice Claymore
            { 7964, new List<List<int>>() }, // Soma Prime
            { 7796, new List<List<int>>() }, // Soul Harvester
            { 7637, new List<List<int>>() }, // Soul Piercer
            { 7965, new List<List<int>>() }, // Spark Spreader
            { 8109, new List<List<int>>() }, // Spear of Destiny
            { 8110, new List<List<int>>() }, // Spear of Paleolith
            { 7966, new List<List<int>>() }, // Spectralstorm Cannon
            { 7967, new List<List<int>>() }, // Speed Blaster
            { 8111, new List<List<int>>() }, // Spent Fuel Container
            { 8217, new List<List<int>>() }, // Spikecrag Staff
            { 7797, new List<List<int>>() }, // Spine of Thanatos
            { 8112, new List<List<int>>() }, // Spore Knife
            { 7968, new List<List<int>>() }, // Spyker
            { 8218, new List<List<int>>() }, // Squirrel Squire Staff
            { 7638, new List<List<int>>() }, // Staff of Blushie
            { 8219, new List<List<int>>() }, // Staff of Necrosteocytes
            { 8113, new List<List<int>>() }, // Star of Destruction
            { 7639, new List<List<int>>() }, // Star Shower
            { 7972, new List<List<int>>() }, // Star Sputter
            { 8246, new List<List<int>>() }, // Star Struck Water
            { 7969, new List<List<int>>() }, // Starfleet
            { 7970, new List<List<int>>() }, // Starmada
            { 7971, new List<List<int>>() }, // Starmageddon
            { 7798, new List<List<int>>() }, // Starnight Lance
            { 8220, new List<List<int>>() }, // Starspawn Helix Staff
            { 7973, new List<List<int>>() }, // Stellar Cannon
            { 7799, new List<List<int>>() }, // Stellar Contempt
            { 8114, new List<List<int>>() }, // Stellar Knife
            { 7800, new List<List<int>>() }, // Stellar Striker
            { 8221, new List<List<int>>() }, // Stellar Torus Staff
            { 7801, new List<List<int>>() }, // Storm Ruler
            { 7802, new List<List<int>>() }, // Storm Saber
            { 7974, new List<List<int>>() }, // Storm Surge
            { 8115, new List<List<int>>() }, // Stormfront Razor
            { 8222, new List<List<int>>() }, // Stormjaw Staff
            { 8247, new List<List<int>>() }, // Stratus Sphere
            { 7803, new List<List<int>>() }, // Stream Gouge
            { 7804, new List<List<int>>() }, // Stygian Shield
            { 8116, new List<List<int>>() }, // Subduction Slicer
            { 7805, new List<List<int>>() }, // Submarine Shocker
            { 7640, new List<List<int>>() }, // Subsuming Vortex
            { 7975, new List<List<int>>() }, // Sulphuric Acid Cannon
            { 7806, new List<List<int>>() }, // Sulphurous Grabber
            { 8223, new List<List<int>>() }, // Sun Spirit Staff
            { 8117, new List<List<int>>() }, // Supernova
            { 7976, new List<List<int>>() }, // Superradiant Slaughterer
            { 7977, new List<List<int>>() }, // Surge Driver
            { 7978, new List<List<int>>() }, // Svantechnical
            { 7807, new List<List<int>>() }, // Swordsplosion
            { 7641, new List<List<int>>() }, // Sylvestaff
            { 7527, new List<List<int>>() }, // System Bane
            { 8224, new List<List<int>>() }, // Tactical Plague Engine
            { 7642, new List<List<int>>() }, // Tactician's Trump Card
            { 7808, new List<List<int>>() }, // Tainted Blade
            { 8118, new List<List<int>>() }, // Tarragon Throwing Dart
            { 7979, new List<List<int>>() }, // Tau Cannon
            { 7809, new List<List<int>>() }, // Teardrop Cleaver
            { 7643, new List<List<int>>() }, // Tears of Heaven
            { 7980, new List<List<int>>() }, // Telluric Glare
            { 8225, new List<List<int>>() }, // Temporal Umbrella
            { 7810, new List<List<int>>() }, // Tenebreus Tides
            { 7811, new List<List<int>>() }, // Terratomere
            { 7812, new List<List<int>>() }, // Terror Blade
            { 8119, new List<List<int>>() }, // Terror Talons
            { 7528, new List<List<int>>() }, // Tesla Cannon
            { 7644, new List<List<int>>() }, // Teslastaff
            { 7529, new List<List<int>>() }, // The Anomaly's Nanogun
            { 8120, new List<List<int>>() }, // The Atom Splitter
            { 7981, new List<List<int>>() }, // The Ballista
            { 7813, new List<List<int>>() }, // The Burning Sky
            { 7645, new List<List<int>>() }, // The Cauldron
            { 7646, new List<List<int>>() }, // The Dance of Light
            { 7814, new List<List<int>>() }, // The Dark Master
            { 8121, new List<List<int>>() }, // The Final Dawn
            { 7815, new List<List<int>>() }, // The God's Gambit
            { 7982, new List<List<int>>() }, // The Hive
            { 7983, new List<List<int>>() }, // The Jailor
            { 7816, new List<List<int>>() }, // The Last Mourning
            { 7984, new List<List<int>>() }, // The Maelstrom
            { 7817, new List<List<int>>() }, // The Microwave
            { 7818, new List<List<int>>() }, // The Mutilator
            { 7819, new List<List<int>>() }, // The Obliterator
            { 8122, new List<List<int>>() }, // The Old Reaper
            { 7820, new List<List<int>>() }, // The Oracle
            { 7985, new List<List<int>>() }, // The Pack
            { 7647, new List<List<int>>() }, // The Prince
            { 7987, new List<List<int>>() }, // The Sevens Striker
            { 7988, new List<List<int>>() }, // The Storm
            { 7648, new List<List<int>>() }, // The Swarmer
            { 8123, new List<List<int>>() }, // The Syringe
            { 7649, new List<List<int>>() }, // The Wand
            { 7986, new List<List<int>>() }, // Thermocline Blaster
            { 7650, new List<List<int>>() }, // Thorn Blossom
            { 7989, new List<List<int>>() }, // Thread of Eradication
            { 8124, new List<List<int>>() }, // Throwing Brick
            { 8125, new List<List<int>>() }, // Time Bolt
            { 7821, new List<List<int>>() }, // Titan Arm
            { 7990, new List<List<int>>() }, // Titanium Railgun
            { 8126, new List<List<int>>() }, // Titanium Shuriken
            { 8127, new List<List<int>>() }, // Tooth Ball
            { 8128, new List<List<int>>() }, // Totality Breakers
            { 7991, new List<List<int>>() }, // Toxibow
            { 8129, new List<List<int>>() }, // Toxicant Twister
            { 7651, new List<List<int>>() }, // Tradewinds
            { 7822, new List<List<int>>() }, // Triactis' True Paladinian Mage-Hammer of Might
            { 7771, new List<List<int>>() }, // True Biome Blade
            { 7826, new List<List<int>>() }, // Tumbleweed
            { 8226, new List<List<int>>() }, // Tundra Flame Blossoms Staff
            { 8130, new List<List<int>>() }, // Turbulance
            { 8131, new List<List<int>>() }, // Twisting Thunder
            { 7827, new List<List<int>>() }, // Typhon's Greed
            { 7992, new List<List<int>>() }, // Tyranny's End
            { 7993, new List<List<int>>() }, // Ultima
            { 7828, new List<List<int>>() }, // Ultimus Cleaver
            { 7652, new List<List<int>>() }, // Ultra Liquidator
            { 7653, new List<List<int>>() }, // Undine's Retribution
            { 7994, new List<List<int>>() }, // Universal Genesis
            { 8227, new List<List<int>>() }, // Universe Splitter
            { 7654, new List<List<int>>() }, // Unstable Caster's Gauntlet
            { 7829, new List<List<int>>() }, // Urchin Mace
            { 8132, new List<List<int>>() }, // Urchin Stinger
            { 8133, new List<List<int>>() }, // Utensil Poker
            { 8134, new List<List<int>>() }, // Valediction
            { 7655, new List<List<int>>() }, // Valkyrie Ray
            { 7830, new List<List<int>>() }, // Vanishing Point
            { 7656, new List<List<int>>() }, // Veering Wind
            { 8135, new List<List<int>>() }, // Vega
            { 7657, new List<List<int>>() }, // Vehemence
            { 7831, new List<List<int>>() }, // Vein Burster
            { 8228, new List<List<int>>() }, // Vengeful Sun Staff
            { 7658, new List<List<int>>() }, // Venusian Trident
            { 7995, new List<List<int>>() }, // Vernal Bolter
            { 7659, new List<List<int>>() }, // Vesuvius
            { 8229, new List<List<int>>() }, // Vigilance
            { 8230, new List<List<int>>() }, // Vile Feeder
            { 7832, new List<List<int>>() }, // Violence
            { 8231, new List<List<int>>() }, // Viral Sprout
            { 8232, new List<List<int>>() }, // Virid Vanguard
            { 7833, new List<List<int>>() }, // Virulence
            { 7660, new List<List<int>>() }, // Viscera
            { 7661, new List<List<int>>() }, // Vitriolic Viper
            { 7662, new List<List<int>>() }, // Vivid Clarity
            { 8233, new List<List<int>>() }, // Void Concentration Staff
            { 8234, new List<List<int>>() }, // Void Eater Marionette
            { 7834, new List<List<int>>() }, // Void Edge
            { 7663, new List<List<int>>() }, // Void Vortex
            { 7996, new List<List<int>>() }, // Voidragon
            { 7664, new List<List<int>>() }, // Voltaic Climax
            { 7665, new List<List<int>>() }, // Volterion
            { 7997, new List<List<int>>() }, // Vortexpopper
            { 7835, new List<List<int>>() }, // Vulcanite Lance
            { 7515, new List<List<int>>() }, // W-LSR: Phalanx Surge
            { 8235, new List<List<int>>() }, // Warloks' Moon Fist
            { 7531, new List<List<int>>() }, // Wave Pounder
            { 8136, new List<List<int>>() }, // Wave Skipper
            { 7666, new List<List<int>>() }, // Waywasher
            { 8137, new List<List<int>>() }, // Web Ball
            { 8138, new List<List<int>>() }, // Whitewater
            { 7998, new List<List<int>>() }, // Wildfire Bloom
            { 7836, new List<List<int>>() }, // Wind Blade
            { 7667, new List<List<int>>() }, // Wingman
            { 7668, new List<List<int>>() }, // Winter's Fury
            { 8236, new List<List<int>>() }, // Wither Blossoms Staff
            { 8139, new List<List<int>>() }, // Wrathwing
            { 7999, new List<List<int>>() }, // Wulfrum Blunderbuss
            { 8237, new List<List<int>>() }, // Wulfrum Controller
            { 8140, new List<List<int>>() }, // Wulfrum Knife
            { 7669, new List<List<int>>() }, // Wulfrum Prosthesis
            { 7837, new List<List<int>>() }, // Wulfrum Screwdriver
            { 7670, new List<List<int>>() }, // Wyvern's Call
            { 7838, new List<List<int>>() }, // Yateveo Bloom
            { 7671, new List<List<int>>() }, // Yharim's Crystal
            { 8238, new List<List<int>>() }, // Yharon's Kindle Staff
            { 7839, new List<List<int>>() }, // Yin-Yo
        };
    }
}
