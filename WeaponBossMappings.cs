using CalamityMod.NPCs.SupremeCalamitas;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityWeaponChecklist
{
    public static class WeaponBossMappings
    {
        public static readonly Dictionary<int, int> Mapping = new()
        {
            // Format:
            // { itemType, bossType }

            { 7523, -1 }, // A-PLS: Pulse Rifle
            { 8141, -1 }, // Abandoned Slime Staff
            { 7672, -1 }, // Absolute Zero
            { 7673, -1 }, // Abyss Blade
            { 7533, -1 }, // Abyss Shocker
            { 7532, -1 }, // Abyssal Tome
            { 7840, -1 }, // Ace's High
            { 7534, -1 }, // Acid Gun
            { 7841, -1 }, // Acidwood Bow
            { 7674, -1 }, // Acidwood Sword
            { 7842, -1 }, // Adamantite Particle Accelerator
            { 8000, -1 }, // Adamantite Throwing Axe
            { 7675, -1 }, // Aegis Blade
            { 8239, -1 }, // Aestheticus
            { 7536, -1 }, // Aether's Whisper
            { 7535, -1 }, // Aetherflux Cannon
            { 7676, -1 }, // Air Spinner
            { 7843, -1 }, // Alluvion
            { 7537, -1 }, // Alpha Draconis
            { 7538, -1 }, // Alula Australis
            { 7677, -1 }, // Amidias' Trident
            { 8142, -1 }, // Amphibian's Guitar
            { 7539, -1 }, // Anahita's Arpeggio
            { 7678, -1 }, // Anarchy Blade
            { 8143, -1 }, // Ancient Ice Chunk
            { 7844, -1 }, // Angelic Shotgun
            { 7845, -1 }, // Animosity
            { 7846, -1 }, // Anti-materiel Rifle
            { 8001, -1 }, // Antlion Skewer
            { 7679, -1 }, // Aorta
            { 7540, -1 }, // Apathanull
            { 8002, -1 }, // Apoctolith
            { 7541, -1 }, // Apoctosis Array
            { 7542, -1 }, // Apotheosis
            { 8144, -1 }, // Aqua's Scepter
            { 7543, -1 }, // Aquamarine Staff
            { 7847, -1 }, // Aquashard Shotgun
            { 7848, -1 }, // Arbalest
            { 7850, -1 }, // Arc Nova Diffuser
            { 7544, -1 }, // Arch Amaryllis
            { 7849, -1 }, // Archerfish
            { 7545, -1 }, // Arctic Bear Paw
            { 8145, -1 }, // Ares' Exoskeleton
            { 7851, -1 }, // Arietes 41
            { 7823, -1 }, // Ark of the Ancients
            { 7680, -1 }, // Ark of the Cosmos
            { 7681, -1 }, // Ark of the Elements
            { 7546, -1 }, // Art Attack
            { 7852, -1 }, // Arterial Assault
            { 8003, -1 }, // Ashen Stalactite
            { 7853, -1 }, // Astral Blaster
            { 7682, -1 }, // Astral Pike
            { 7683, -1 }, // Astral Scythe
            { 7548, -1 }, // Astral Staff
            { 7547, -1 }, // Astralachnea Staff
            { 7854, -1 }, // Astreal Defeat
            { 7684, -1 }, // Ataraxia
            { 7549, -1 }, // Atlantis
            { 8146, -1 }, // Atlas Munitions Beacon
            { 7550, -1 }, // Augur of the Void
            { 7855, -1 }, // Auralis
            { 7856, -1 }, // Aurora Blazer
            { 8004, -1 }, // Auroradical Throw
            { 7685, -1 }, // Avalanche
            { 7514, -1 }, // B-GSS: Nidhogg
            { 7509, -1 }, // B-LSR: Countermeasure Mitt
            { 7686, -1 }, // Baleful Harvester
            { 7687, -1 }, // Ball O' Fugu
            { 8005, -1 }, // Ballistic Poison Bomb
            { 7688, -1 }, // Banshee Hook
            { 7857, -1 }, // Barinade
            { 7858, -1 }, // Barinautical
            { 7859, -1 }, // Barracuda Gun
            { 7689, -1 }, // Basher
            { 7551, -1 }, // Belching Saxophone
            { 8147, -1 }, // Belladonna Spirit Staff
            { 7552, -1 }, // Biofusillade
            { 7824, -1 }, // Biome Blade
            { 7553, -1 }, // Black Anurian
            { 8148, -1 }, // Black Hawk Remote
            { 7690, -1 }, // Bladecrest Oathsword
            { 7860, -1 }, // Bladedge Railbow
            { 8006, -1 }, // Blast Barrel
            { 8007, -1 }, // Blazing Star
            { 7861, -1 }, // Blight Spewer
            { 7691, -1 }, // Blighted Cleaver
            { 7862, -1 }, // Blissful Bombardier
            { 7554, -1 }, // Blood Bath
            { 7863, -1 }, // Blood Boiler
            { 8008, -1 }, // Bloodsoaked Crasher
            { 7864, -1 }, // Blossom Flux
            { 7692, -1 }, // Bonebreaker
            { 8149, -1 }, // Borealis Bomber
            { 7693, -1 }, // Botanic Piercer
            { 8009, -1 }, // Bouncing Eyeball
            { 8010, -1 }, // Brimblade
            { 7694, -1 }, // Brimlance
            { 7695, -1 }, // Brimlash
            { 7555, -1 }, // Brimrose Staff
            { 7865, -1 }, // Brimstone Fury
            { 7696, -1 }, // Brimstone Sword
            { 7697, -1 }, // Briny Baron
            { 8150, -1 }, // Brittle Star Staff
            { 7698, -1 }, // Broken Biome Blade
            { 7866, -1 }, // Bullet-Filled Shotgun
            { 7699, -1 }, // Burning Revelation
            { 7556, -1 }, // Burning Sea
            { 8011, -1 }, // Burning Strife
            { 7700, -1 }, // Burnt Sienna
            { 7867, -1 }, // Buzzkill
            { 8151, -1 }, // Cadaverous Carrion
            { 8152, -1 }, // Calamari's Lament
            { 7701, -1 }, // Carnage
            { 8153, -1 }, // Caustic Croaker Staff
            { 7825, -1 }, // Caustic Edge
            { 8154, -1 }, // Caustic Staff
            { 7702, -1 }, // Celestial Claymore
            { 8012, -1 }, // Celestial Reaper
            { 8013, -1 }, // Celestus
            { 7868, -1 }, // Chicken Cannon
            { 7869, -1 }, // Chromatic Eruption
            { 7557, -1 }, // Chronomancer's Scythe
            { 8155, -1 }, // Cinder Blossom Staff
            { 8156, -1 }, // Cinders of Lament
            { 8014, -1 }, // Cinquedea
            { 7703, -1 }, // Clam Crusher
            { 7870, -1 }, // Clamor Rifle
            { 8240, -1 }, // Claret Cannon
            { 7871, -1 }, // Cleansing Blaze
            { 7872, -1 }, // Clockwork Bow
            { 7558, -1 }, // Clothier's Wrath
            { 8157, -1 }, // Cnidarian
            { 8015, -1 }, // Cobalt Kunai
            { 8241, -1 }, // Coldheart Icicle
            { 7704, -1 }, // Comet Quasher
            { 7873, -1 }, // Condemnation
            { 7874, -1 }, // Conference Call
            { 8016, -1 }, // Consecrated Water
            { 7875, -1 }, // Contagion
            { 8017, -1 }, // Contaminated Bile
            { 7876, -1 }, // Continental Greatbow
            { 7559, -1 }, // Coral Spout
            { 7877, -1 }, // Corinth Prime
            { 8018, -1 }, // Corpus Avertor
            { 7878, -1 }, // Corroded Caustibow
            { 8158, -1 }, // Corroslime Staff
            { 8159, -1 }, // Corvid Harbinger Staff
            { 7705, -1 }, // Cosmic Discharge
            { 8160, -1 }, // Cosmic Immaterializer
            { 8019, -1 }, // Cosmic Kunai
            { 7560, -1 }, // Cosmic Rainbow
            { 7706, -1 }, // Cosmic Shiv
            { 8161, -1 }, // Cosmic Viper Engine
            { 8162, -1 }, // Cosmilamp
            { 7879, -1 }, // Crackshot Colt
            { 8020, -1 }, // Cranium Smasher
            { 7707, -1 }, // Crescent Moon
            { 8163, -1 }, // Crimslime Staff
            { 8021, -1 }, // Crushsaw Crasher
            { 8164, -1 }, // Cryogenic Staff
            { 7561, -1 }, // Cryophobia
            { 8023, -1 }, // Crystal Piercer
            { 8022, -1 }, // Crystalline
            { 8024, -1 }, // Cursed Dagger
            { 8165, -1 }, // Daedalus Golem Staff
            { 7880, -1 }, // Daemon's Flame
            { 8166, -1 }, // Dank Staff
            { 7562, -1 }, // Dark Spark
            { 7881, -1 }, // Darkecho Greatbow
            { 7708, -1 }, // Darklight Greatsword
            { 8167, -1 }, // Dazzling Stabber Staff
            { 7882, -1 }, // Dead Sun's Wind
            { 7563, -1 }, // Death Valley Duster
            { 7709, -1 }, // Death's Ascension
            { 8168, -1 }, // Deathstare Rod
            { 8025, -1 }, // Deep Sea Dumbbell
            { 8026, -1 }, // Deep Wounder
            { 7883, -1 }, // Deepcore GK2
            { 8169, -1 }, // Deepsea Staff
            { 8027, -1 }, // Defective Sphere
            { 7710, -1 }, // Defiled Greatsword
            { 7711, -1 }, // Depth Crusher
            { 8028, -1 }, // Desecrated Water
            { 7712, -1 }, // Devil's Devastation
            { 7713, -1 }, // Devil's Sunrise
            { 8029, -1 }, // Dimension-Tearing Disk
            { 8030, -1 }, // Doomsday Device
            { 8170, -1 }, // Dormant Brimseeker
            { 7564, -1 }, // Downpour
            { 7714, -1 }, // Draconic Destruction
            { 7715, -1 }, // Dragon Pow
            { 7716, -1 }, // Dragon Rage
            { 7884, -1 }, // Dragon's Breath
            { 8171, -1 }, // Dragonblood Disgorger
            { 7885, -1 }, // Drataliornus
            { 8172, -1 }, // Dreadmine Staff
            { 7886, -1 }, // Driftwood Bow
            { 7717, -1 }, // Driftwood Sword
            { 8031, -1 }, // Duke's Decapitator
            { 8032, -1 }, // Duststorm in a Bottle
            { 8033, -1 }, // Dynamic Pursuer
            { 7718, -1 }, // Earth
            { 7719, -1 }, // Earthen Pike
            { 8034, -1 }, // Eclipse's Fall
            { 7565, -1 }, // Effervescence
            { 7566, -1 }, // Eidolic Wail
            { 7567, -1 }, // Eidolon Staff
            { 7568, -1 }, // Eldritch Tome
            { 7720, -1 }, // Empyrean Knives
            { 8035, -1 }, // Enchanted Axe
            { 8173, -1 }, // Enchanted Conch
            { 8174, -1 }, // Enchanted Knife Staff
            { 8176, -1 }, // Endo Hydra Staff
            { 8175, -1 }, // Endogenesis
            { 7721, -1 }, // Entropic Claymore
            { 8177, -1 }, // Entropy's Vigil
            { 8036, -1 }, // Epidemic Shredder
            { 8037, -1 }, // Equanimity
            { 7722, -1 }, // Essence Flayer
            { 7887, -1 }, // Eternal Blizzard
            { 7569, -1 }, // Eternity
            { 8178, -1 }, // Ethereal Subjugator
            { 7570, -1 }, // Event Horizon
            { 7571, -1 }, // Everglade Spray
            { 7723, -1 }, // Evil Smasher
            { 7888, -1 }, // Eviscerator
            { 7724, -1 }, // Exalted Oathblade
            { 8038, -1 }, // Executioner's Blade
            { 7725, -1 }, // Exoblade
            { 8039, -1 }, // Exorcism
            { 8242, -1 }, // Eye of Magnus
            { 8179, -1 }, // Eye of Night
            { 7572, -1 }, // Face Melter
            { 7726, -1 }, // Fallen Paladin's Hammer
            { 8040, -1 }, // Fantasy Talisman
            { 7573, -1 }, // Fate's Reveal
            { 7727, -1 }, // Fault Line
            { 8041, -1 }, // Feather Knife
            { 7728, -1 }, // Feralthorn Claymore
            { 7889, -1 }, // Fetid Emesis
            { 7890, -1 }, // Firestorm Cannon
            { 8042, -1 }, // Fishbone Boomerang
            { 7891, -1 }, // Flak Kraken
            { 7892, -1 }, // Flak Toxicannon
            { 8180, -1 }, // Flamsteed Ring
            { 7574, -1 }, // Flare Bolt
            { 7729, -1 }, // Flarefrost Blade
            { 7893, -1 }, // Flarewing Bow
            { 8181, -1 }, // Flesh of Infidelity
            { 7730, -1 }, // Floodtide
            { 8182, -1 }, // Flowers of Mortality
            { 7894, -1 }, // Flurrystorm Cannon
            { 7731, -1 }, // Forbidden Oathblade
            { 7575, -1 }, // Forbidden Sun
            { 8183, -1 }, // Forgotten Apex Wand
            { 7732, -1 }, // Forsaken Saber
            { 7734, -1 }, // Fractured Ark
            { 7895, -1 }, // Freedom Star
            { 7576, -1 }, // Frigidflash Bolt
            { 8184, -1 }, // Frost Blossom Staff
            { 7577, -1 }, // Frost Bolt
            { 7896, -1 }, // Frostbite Blaster
            { 8043, -1 }, // Frostcrush Valari
            { 8044, -1 }, // Frosty Flare
            { 8185, -1 }, // Fuel Cell Bundle
            { 7897, -1 }, // Fungicide
            { 8045, -1 }, // Gacruxian Mollusk
            { 7735, -1 }, // Gael's Greatsword
            { 7736, -1 }, // Galactus Blade
            { 7733, -1 }, // Galaxia
            { 7737, -1 }, // Galaxy Smasher
            { 7898, -1 }, // Galeforce
            { 7738, -1 }, // Galileo Gladius
            { 7510, -1 }, // Galvanizing Glaive
            { 8186, -1 }, // Gamma Heart
            { 8187, -1 }, // Gastric Belcher Staff
            { 8046, -1 }, // Gel Dart
            { 7739, -1 }, // Gelitic Blade
            { 7578, -1 }, // Genesis
            { 7579, -1 }, // Ghastly Visage
            { 8047, -1 }, // Ghoulish Gouger
            { 8048, -1 }, // Gilded Dagger
            { 7740, -1 }, // Gilded Proboscis
            { 8188, -1 }, // Glacial Embrace
            { 8049, -1 }, // Glaive
            { 8050, -1 }, // Gleaming Dagger
            { 7580, -1 }, // Gleaming Magnolia
            { 7581, -1 }, // Glorious End
            { 8051, -1 }, // Gods' Paranoia
            { 7899, -1 }, // Golden Eagle
            { 7741, -1 }, // Goldplume Spear
            { 7900, -1 }, // Goobow
            { 7742, -1 }, // Grand Dad
            { 7743, -1 }, // Grand Guardian
            { 8052, -1 }, // Grave Grimreaver
            { 7744, -1 }, // Greatsword of Judgement
            { 7745, -1 }, // Greentide
            { 7582, -1 }, // Gruesome Eminence
            { 8189, -1 }, // Guidelight of Oblivion
            { 7901, -1 }, // Gunk Shot
            { 7583, -1 }, // Hadal Urn
            { 7902, -1 }, // Halibut Cannon
            { 7903, -1 }, // Halley's Inferno
            { 7904, -1 }, // Handheld Tank
            { 8053, -1 }, // Hardened Honeycomb
            { 8190, -1 }, // Harvest Staff
            { 8191, -1 }, // Haunted Scroll
            { 7905, -1 }, // Havoc's Breath
            { 8054, -1 }, // Heavenfallen Stardisk
            { 7906, -1 }, // Heavenly Gale
            { 7584, -1 }, // Helium Flash
            { 7907, -1 }, // Hellborn
            { 7746, -1 }, // Hellfire Flamberge
            { 7747, -1 }, // Hellion Flower Spear
            { 7748, -1 }, // Hellkite
            { 7585, -1 }, // Hellwing Staff
            { 7908, -1 }, // Helstorm
            { 7586, -1 }, // Hematemesis
            { 7587, -1 }, // Heresy
            { 8192, -1 }, // Herring Staff
            { 8193, -1 }, // Hive Pod
            { 7909, -1 }, // Hoarfrost Bow
            { 7749, -1 }, // Holy Collider
            { 7910, -1 }, // Hydra
            { 7512, -1 }, // Hydraulic Volt Crasher
            { 7588, -1 }, // Hyperdeath Rift Scepter
            { 7589, -1 }, // Hyphae Rod
            { 8055, -1 }, // Hypothermia
            { 7590, -1 }, // Ice Barrage
            { 8057, -1 }, // Ice Star
            { 8056, -1 }, // Icebreaker
            { 8058, -1 }, // Ichor Spear
            { 7591, -1 }, // Icicle Staff
            { 7592, -1 }, // Icicle Trident
            { 8194, -1 }, // Igneous Exaltation
            { 7750, -1 }, // Illustrious Knives
            { 8195, -1 }, // Infected Remote
            { 8059, -1 }, // Infernal Kris
            { 7593, -1 }, // Infernal Rift
            { 8060, -1 }, // Infested Clawmerang
            { 7911, -1 }, // Infinity
            { 7751, -1 }, // Insidious Impaler
            { 7594, -1 }, // Ion Blaster
            { 8061, -1 }, // Iron Francisca
            { 8062, -1 }, // Jaws of Oblivion
            { 7912, -1 }, // Karasawa
            { 7595, -1 }, // Keelhaul
            { 8063, -1 }, // Kelvin Catalyst
            { 8196, -1 }, // King of Constellations, Tenryū
            { 7913, -1 }, // Kingsbane
            { 8064, -1 }, // Kylie
            { 7752, -1 }, // Lacerator
            { 7596, -1 }, // Lashes of Chaos
            { 8065, -1 }, // Lead Tomahawk
            { 8197, -1 }, // Legion of Celestia
            { 8066, -1 }, // Leonid Progenitor
            { 8067, -1 }, // Leviathan Teeth
            { 7914, -1 }, // Leviatitan
            { 7753, -1 }, // Lifehunt Scythe
            { 7597, -1 }, // Light God's Brilliance
            { 7754, -1 }, // Lightspeed
            { 8198, -1 }, // Lilies of Finality
            { 7755, -1 }, // Lion Heart
            { 8068, -1 }, // Lionfish
            { 7756, -1 }, // Lucrecia
            { 8069, -1 }, // Lunar Kunai
            { 7915, -1 }, // Lunarian Bow
            { 8243, -1 }, // Lunic Eye
            { 7916, -1 }, // M1 Garand
            { 7598, -1 }, // Mad Alchemist's Cocktail Glove
            { 7917, -1 }, // Magna Cannon
            { 7599, -1 }, // Magnetic Meltdown
            { 7918, -1 }, // Magnomaly Cannon
            { 7757, -1 }, // Majestic Guard
            { 8070, -1 }, // Malachite
            { 7919, -1 }, // Malevolence
            { 7600, -1 }, // Mana Rose
            { 8071, -1 }, // Mangrove Chakram
            { 7758, -1 }, // Mantis Claws
            { 7920, -1 }, // Marksman Bow
            { 7759, -1 }, // Maw of Infinity
            { 7921, -1 }, // Megalodon
            { 7922, -1 }, // Meowthrower
            { 8072, -1 }, // Metal Monstrosity
            { 8199, -1 }, // Metastasis
            { 8073, -1 }, // Meteor Fist
            { 7601, -1 }, // Miasma
            { 7923, -1 }, // Midas Prime
            { 8200, -1 }, // Midnight Sun Beacon
            { 7924, -1 }, // Mineral Mortar
            { 7760, -1 }, // Mirror Blade
            { 8201, -1 }, // Mirror of Kalandra
            { 7602, -1 }, // Mistlestorm
            { 8074, -1 }, // Molten Amputator
            { 7925, -1 }, // Monolith Bow
            { 7761, -1 }, // Monolith Sword
            { 7926, -1 }, // Monsoon
            { 7762, -1 }, // Monstrous Knives
            { 7513, -1 }, // Mounted Scanner
            { 7763, -1 }, // Mourningstar
            { 7764, -1 }, // Murasama
            { 8202, -1 }, // Mutated Truffle
            { 7765, -1 }, // Mycelial Claws
            { 8075, -1 }, // Mycoroot
            { 8076, -1 }, // Mythril Knife
            { 7766, -1 }, // Nadir
            { 7603, -1 }, // Nano Purge
            { 8077, -1 }, // Nanoblack Reaper
            { 8078, -1 }, // Nasty Cholla
            { 7767, -1 }, // Nebulash
            { 7604, -1 }, // Nebulous Cataclysm
            { 7927, -1 }, // Needler
            { 7768, -1 }, // Neptune's Bounty
            { 7928, -1 }, // Nettlevine Greatbow
            { 7605, -1 }, // Night's Ray
            { 7929, -1 }, // Nitro Express Rifle
            { 7930, -1 }, // Norfleet
            { 7606, -1 }, // Nuclear Fury
            { 7607, -1 }, // Nucleosynthesis
            { 7931, -1 }, // Nullification Pistol
            { 7769, -1 }, // Oblivion
            { 7770, -1 }, // Old Lord Claymore
            { 7608, -1 }, // Omicron
            { 7772, -1 }, // Omniblade
            { 7932, -1 }, // Ontological Despoiler
            { 7933, -1 }, // Onyx Chain Blaster
            { 7934, -1 }, // Onyxia
            { 7935, -1 }, // Opal Striker
            { 7773, -1 }, // Orderbringer
            { 8079, -1 }, // Orichalcum Spiked Gemstone
            { 8203, -1 }, // Orthocera Shell
            { 7936, -1 }, // Overloaded Blaster
            { 7774, -1 }, // Ozzathoth
            { 7508, -1 }, // P-GSS: Auger
            { 7506, -1 }, // P-LSR: Aerial Tracker
            { 7522, -1 }, // P-PLS: Pulse Pistol
            { 7507, -1 }, // P-PMA: Aqueous Hunter Drone
            { 7525, -1 }, // P-TSL: Short Circuit
            { 7937, -1 }, // P90
            { 8080, -1 }, // Palladium Javelin
            { 7775, -1 }, // Pandemic
            { 7609, -1 }, // Parasitic Scepter
            { 7938, -1 }, // Pearl God
            { 8081, -1 }, // Penumbra
            { 8204, -1 }, // Perdition
            { 7776, -1 }, // Perfect Dark
            { 7939, -1 }, // Pestilent Defiler
            { 7610, -1 }, // Phantasmal Fury
            { 8082, -1 }, // Phantasmal Ruin
            { 7516, -1 }, // Phaseslayer
            { 7611, -1 }, // Phoenix Flame Barrage
            { 7777, -1 }, // Phosphorescent Gauntlet
            { 7778, -1 }, // Photon Ripper
            { 7612, -1 }, // Photosynthesis
            { 7940, -1 }, // Photoviscerator
            { 7613, -1 }, // Plague Staff
            { 7941, -1 }, // Plague Tainted SMG
            { 8083, -1 }, // Plaguenade
            { 7942, -1 }, // Planetary Annihilation
            { 8205, -1 }, // Plantation Staff
            { 7517, -1 }, // Plasma Caster
            { 7518, -1 }, // Plasma Grenade
            { 7614, -1 }, // Plasma Rifle
            { 7615, -1 }, // Plasma Rod
            { 7943, -1 }, // Polaris Parrotfish
            { 7519, -1 }, // Pole Warper
            { 8206, -1 }, // Polyp Launcher
            { 7616, -1 }, // Poseidon
            { 7944, -1 }, // Prideful Hunter's Planar Ripper
            { 7617, -1 }, // Primordial Ancient
            { 7618, -1 }, // Primordial Earth
            { 8084, -1 }, // Prismalline
            { 7779, -1 }, // Prismatic Breaker
            { 7945, -1 }, // Pristine Fury
            { 8085, -1 }, // Profaned Partisan
            { 8207, -1 }, // Puff Shroom
            { 7520, -1 }, // Pulse Dragon
            { 7524, -1 }, // Pulse Turret Remote
            { 8086, -1 }, // Pumpkaboom
            { 7946, -1 }, // Pumpler
            { 7619, -1 }, // Purge Guzzler
            { 7780, -1 }, // Pwnagehammer
            { 7781, -1 }, // Quagmire
            { 7530, -1 }, // R-GSS: Vulcan
            { 7521, -1 }, // R-PLS: Pulse Grenade
            { 7511, -1 }, // R-PMA: Holofibre Immolator
            { 8087, -1 }, // Radiant Star
            { 7620, -1 }, // Rainbow Party Cannon
            { 7621, -1 }, // Rancor
            { 8088, -1 }, // Reality Rupture
            { 7947, -1 }, // Realm Ravager
            { 8089, -1 }, // Rebounding Rainbow
            { 7622, -1 }, // Recitation of the Beast
            { 7782, -1 }, // Red Sun
            { 7948, -1 }, // Reed Blowgun
            { 8090, -1 }, // Refraction Rotor
            { 8091, -1 }, // Regulus Riot
            { 8244, -1 }, // Relic of Deliverance
            { 7623, -1 }, // Relic of Ruin
            { 7783, -1 }, // Rem's Revenge
            { 7784, -1 }, // Respiteblock
            { 8208, -1 }, // Resurrection Butterfly
            { 7949, -1 }, // Riftburst
            { 7785, -1 }, // Riptide
            { 8092, -1 }, // Rot Ball
            { 7624, -1 }, // Rouge Slash
            { 7786, -1 }, // Roxcalibur
            { 7950, -1 }, // Rubico Prime
            { 8209, -1 }, // Rusty Beacon Prototype
            { 8093, -1 }, // Sacrifice
            { 7787, -1 }, // Sahara Slicers
            { 8094, -1 }, // Samsara Slicer
            { 8210, -1 }, // Sanctified Spark
            { 8095, -1 }, // Sand Dollar
            { 8211, -1 }, // Sand Sharknado Staff
            { 7951, -1 }, // Sandblaster
            { 7625, -1 }, // Sandstream Scepter
            { 7626, -1 }, // Sanguine Flare
            { 8212, -1 }, // Saros Possession
            { 7788, -1 }, // Sausage Maker
            { 8213, -1 }, // Scab Ripper
            { 8096, -1 }, // Scarlet Devil
            { 7952, -1 }, // Scorched Earth
            { 7953, -1 }, // Scorpio
            { 7789, -1 }, // Scourge of the Cosmos
            { 8097, -1 }, // Scourge of the Desert
            { 8098, -1 }, // Scourge of the Seas
            { 7954, -1 }, // SDFMG
            { 7956, -1 }, // Sea's Searing
            { 7955, -1 }, // Seadragon
            { 8099, -1 }, // Seafoam Bomb
            { 8100, -1 }, // Sealed Singularity
            { 7790, -1 }, // Seashine Sword
            { 7791, -1 }, // Seeking Scorcher
            { 7627, -1 }, // Seething Discharge
            { 7957, -1 }, // Septic Skewer
            { 8101, -1 }, // Seraphim
            { 7628, -1 }, // Serpentine
            { 7629, -1 }, // Shadecrystal Barrage
            { 7630, -1 }, // Shaderain Staff
            { 7958, -1 }, // Shadethrower
            { 7631, -1 }, // Shadowbolt Staff
            { 8102, -1 }, // Shard of Antumbra
            { 8103, -1 }, // Shattered Dawn
            { 8214, -1 }, // Shellfish Staff
            { 7959, -1 }, // Shellshooter
            { 7632, -1 }, // Shifting Sands
            { 7792, -1 }, // Shimmerspark
            { 8104, -1 }, // Shinobi Blade
            { 7633, -1 }, // SHPC
            { 7960, -1 }, // Shredder
            { 7961, -1 }, // Shroomer
            { 8215, -1 }, // Sirius
            { 7634, -1 }, // Sky Glaze
            { 8105, -1 }, // Skyfin Bombers
            { 8245, -1 }, // Skynamite
            { 7793, -1 }, // Skytide Dragoon
            { 7963, -1 }, // Slag Magnum
            { 7962, -1 }, // Slagfire Douser
            { 8106, -1 }, // Slick Cane
            { 8216, -1 }, // Slime Puppet Staff
            { 7635, -1 }, // Slithering Eels
            { 8107, -1 }, // Sludge Splotch
            { 7794, -1 }, // Smoking Comet
            { 7526, -1 }, // Snake Eyes
            { 8108, -1 }, // Snap Clam
            { 7636, -1 }, // Snowstorm Staff
            { 7795, -1 }, // Solstice Claymore
            { 7964, -1 }, // Soma Prime
            { 7796, -1 }, // Soul Harvester
            { 7637, -1 }, // Soul Piercer
            { 7965, -1 }, // Spark Spreader
            { 8109, -1 }, // Spear of Destiny
            { 8110, -1 }, // Spear of Paleolith
            { 7966, -1 }, // Spectralstorm Cannon
            { 7967, -1 }, // Speed Blaster
            { 8111, -1 }, // Spent Fuel Container
            { 8217, -1 }, // Spikecrag Staff
            { 7797, -1 }, // Spine of Thanatos
            { 8112, -1 }, // Spore Knife
            { 7968, -1 }, // Spyker
            { 8218, -1 }, // Squirrel Squire Staff
            { 7638, -1 }, // Staff of Blushie
            { 8219, -1 }, // Staff of Necrosteocytes
            { 8113, -1 }, // Star of Destruction
            { 7639, -1 }, // Star Shower
            { 7972, -1 }, // Star Sputter
            { 8246, -1 }, // Star Struck Water
            { 7969, -1 }, // Starfleet
            { 7970, -1 }, // Starmada
            { 7971, -1 }, // Starmageddon
            { 7798, -1 }, // Starnight Lance
            { 8220, -1 }, // Starspawn Helix Staff
            { 7973, -1 }, // Stellar Cannon
            { 7799, -1 }, // Stellar Contempt
            { 8114, -1 }, // Stellar Knife
            { 7800, -1 }, // Stellar Striker
            { 8221, -1 }, // Stellar Torus Staff
            { 7801, -1 }, // Storm Ruler
            { 7802, -1 }, // Storm Saber
            { 7974, -1 }, // Storm Surge
            { 8115, -1 }, // Stormfront Razor
            { 8222, -1 }, // Stormjaw Staff
            { 8247, -1 }, // Stratus Sphere
            { 7803, -1 }, // Stream Gouge
            { 7804, -1 }, // Stygian Shield
            { 8116, -1 }, // Subduction Slicer
            { 7805, -1 }, // Submarine Shocker
            { 7640, -1 }, // Subsuming Vortex
            { 7975, -1 }, // Sulphuric Acid Cannon
            { 7806, -1 }, // Sulphurous Grabber
            { 8223, -1 }, // Sun Spirit Staff
            { 8117, -1 }, // Supernova
            { 7976, -1 }, // Superradiant Slaughterer
            { 7977, -1 }, // Surge Driver
            { 7978, -1 }, // Svantechnical
            { 7807, -1 }, // Swordsplosion
            { 7641, -1 }, // Sylvestaff
            { 7527, -1 }, // System Bane
            { 8224, -1 }, // Tactical Plague Engine
            { 7642, -1 }, // Tactician's Trump Card
            { 7808, -1 }, // Tainted Blade
            { 8118, -1 }, // Tarragon Throwing Dart
            { 7979, -1 }, // Tau Cannon
            { 7809, -1 }, // Teardrop Cleaver
            { 7643, -1 }, // Tears of Heaven
            { 7980, -1 }, // Telluric Glare
            { 8225, -1 }, // Temporal Umbrella
            { 7810, -1 }, // Tenebreus Tides
            { 7811, -1 }, // Terratomere
            { 7812, -1 }, // Terror Blade
            { 8119, -1 }, // Terror Talons
            { 7528, -1 }, // Tesla Cannon
            { 7644, -1 }, // Teslastaff
            { 7529, -1 }, // The Anomaly's Nanogun
            { 8120, -1 }, // The Atom Splitter
            { 7981, -1 }, // The Ballista
            { 7813, -1 }, // The Burning Sky
            { 7645, -1 }, // The Cauldron
            { 7646, -1 }, // The Dance of Light
            { 7814, -1 }, // The Dark Master
            { 8121, -1 }, // The Final Dawn
            { 7815, -1 }, // The God's Gambit
            { 7982, -1 }, // The Hive
            { 7983, -1 }, // The Jailor
            { 7816, -1 }, // The Last Mourning
            { 7984, -1 }, // The Maelstrom
            { 7817, -1 }, // The Microwave
            { 7818, -1 }, // The Mutilator
            { 7819, -1 }, // The Obliterator
            { 8122, -1 }, // The Old Reaper
            { 7820, -1 }, // The Oracle
            { 7985, -1 }, // The Pack
            { 7647, -1 }, // The Prince
            { 7987, -1 }, // The Sevens Striker
            { 7988, -1 }, // The Storm
            { 7648, -1 }, // The Swarmer
            { 8123, -1 }, // The Syringe
            { 7649, -1 }, // The Wand
            { 7986, -1 }, // Thermocline Blaster
            { 7650, -1 }, // Thorn Blossom
            { 7989, -1 }, // Thread of Eradication
            { 8124, -1 }, // Throwing Brick
            { 8125, -1 }, // Time Bolt
            { 7821, -1 }, // Titan Arm
            { 7990, -1 }, // Titanium Railgun
            { 8126, -1 }, // Titanium Shuriken
            { 8127, -1 }, // Tooth Ball
            { 8128, -1 }, // Totality Breakers
            { 7991, -1 }, // Toxibow
            { 8129, -1 }, // Toxicant Twister
            { 7651, -1 }, // Tradewinds
            { 7822, -1 }, // Triactis' True Paladinian Mage-Hammer of Might
            { 7771, -1 }, // True Biome Blade
            { 7826, -1 }, // Tumbleweed
            { 8226, -1 }, // Tundra Flame Blossoms Staff
            { 8130, -1 }, // Turbulance
            { 8131, -1 }, // Twisting Thunder
            { 7827, -1 }, // Typhon's Greed
            { 7992, -1 }, // Tyranny's End
            { 7993, -1 }, // Ultima
            { 7828, -1 }, // Ultimus Cleaver
            { 7652, -1 }, // Ultra Liquidator
            { 7653, -1 }, // Undine's Retribution
            { 7994, -1 }, // Universal Genesis
            { 8227, -1 }, // Universe Splitter
            { 7654, -1 }, // Unstable Caster's Gauntlet
            { 7829, -1 }, // Urchin Mace
            { 8132, -1 }, // Urchin Stinger
            { 8133, -1 }, // Utensil Poker
            { 8134, -1 }, // Valediction
            { 7655, -1 }, // Valkyrie Ray
            { 7830, -1 }, // Vanishing Point
            { 7656, -1 }, // Veering Wind
            { 8135, -1 }, // Vega
            { 7657, -1 }, // Vehemence
            { 7831, -1 }, // Vein Burster
            { 8228, -1 }, // Vengeful Sun Staff
            { 7658, -1 }, // Venusian Trident
            { 7995, -1 }, // Vernal Bolter
            { 7659, -1 }, // Vesuvius
            { 8229, -1 }, // Vigilance
            { 8230, -1 }, // Vile Feeder
            { 7832, -1 }, // Violence
            { 8231, -1 }, // Viral Sprout
            { 8232, -1 }, // Virid Vanguard
            { 7833, -1 }, // Virulence
            { 7660, -1 }, // Viscera
            { 7661, -1 }, // Vitriolic Viper
            { 7662, -1 }, // Vivid Clarity
            { 8233, -1 }, // Void Concentration Staff
            { 8234, -1 }, // Void Eater Marionette
            { 7834, -1 }, // Void Edge
            { 7663, -1 }, // Void Vortex
            { 7996, -1 }, // Voidragon
            { 7664, -1 }, // Voltaic Climax
            { 7665, -1 }, // Volterion
            { 7997, -1 }, // Vortexpopper
            { 7835, -1 }, // Vulcanite Lance
            { 7515, -1 }, // W-LSR: Phalanx Surge
            { 8235, -1 }, // Warloks' Moon Fist
            { 7531, -1 }, // Wave Pounder
            { 8136, -1 }, // Wave Skipper
            { 7666, -1 }, // Waywasher
            { 8137, -1 }, // Web Ball
            { 8138, -1 }, // Whitewater
            { 7998, -1 }, // Wildfire Bloom
            { 7836, -1 }, // Wind Blade
            { 7667, -1 }, // Wingman
            { 7668, -1 }, // Winter's Fury
            { 8236, -1 }, // Wither Blossoms Staff
            { 8139, -1 }, // Wrathwing
            { 7999, -1 }, // Wulfrum Blunderbuss
            { 8237, -1 }, // Wulfrum Controller
            { 8140, -1 }, // Wulfrum Knife
            { 7669, -1 }, // Wulfrum Prosthesis
            { 7837, -1 }, // Wulfrum Screwdriver
            { 7670, -1 }, // Wyvern's Call
            { 7838, -1 }, // Yateveo Bloom
            { 7671, -1 }, // Yharim's Crystal
            { 8238, -1 }, // Yharon's Kindle Staff
            { 7839, -1 }, // Yin-Yo
        };
    }
}   