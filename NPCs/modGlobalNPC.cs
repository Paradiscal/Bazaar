using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.NPCs
{
    public class modGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.UndeadViking)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LichenGlobule"), Main.rand.Next(20, 40));
                }
            }

            if (npc.type == NPCID.BoneSerpentHead)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MagmaGlobule"), Main.rand.Next(20, 40));
                }
			}
			
			if (npc.type == NPCID.FlyingFish)
            {
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RainGlobule"), Main.rand.Next(20, 40));
                }
            }
			
			if (npc.type == NPCID.SandSlime)
            {
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AridGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.JungleBat)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TropicGlobule"), Main.rand.Next(20, 40));
                }
			}		
			if (npc.type == NPCID.LavaSlime)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MagmaGlobule"), Main.rand.Next(20, 40));
                }
			}	
			if (npc.type == NPCID.DungeonSlime)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.Tim)
            {
                if (Main.rand.Next(1) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WeirdGlobule"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.SnowFlinx)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LichenGlobule"), Main.rand.Next(20, 40));
                }
			}	
			if (npc.type == NPCID.CursedSkull)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.DoctorBones)
            {
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExoticBoquet"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.ManEater)
            {
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExoticBoquet"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.Hornet)
            {
                if (Main.rand.Next(30) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExoticBoquet"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.LacBeetle)
            {
                if (Main.rand.Next(5) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExoticBoquet"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.GiantFungiBulb)
            {
                if (Main.rand.Next(25) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Portobello"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.FungoFish)
            {
                if (Main.rand.Next(25) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Portobello"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.Piranha)
            {
                if (Main.rand.Next(5) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TropicalGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.JungleSlime)
            {
                if (Main.rand.Next(5) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TropicalGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.SpikedJungleSlime)
            {
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TropicalGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AridGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.Vulture)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AridGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.UmbrellaSlime)
            {
                if (Main.rand.Next(5) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RaindropGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.ZombieRaincoat)
            {
                if (Main.rand.Next(10) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RaindropGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.Snatcher)
            {
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExoticBoquet"), Main.rand.Next(1, 1));
                }
			if (npc.type == NPCID.Reaper)
            {
                if (Main.rand.Next(17) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SubmergedAshes"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.Skeleton)
            {
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GooRattle"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.CaveBat)
            {
                if (Main.rand.Next(30) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WhackTree"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.GiantWormHead)
            {
                if (Main.rand.Next(10) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Axle"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.GreekSkeleton)
            {
                if (Main.rand.Next(50) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Sediment"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.GraniteFlyer)
            {
                if (Main.rand.Next(50) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Sediment"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.DarkCaster)
            {
                if (Main.rand.Next(18) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Atlantean"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.SpikedIceSlime)
            {
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LichenGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.IceBat)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LichenGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.Demolitionist)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HotPotatoes"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.Zombie)
            {
                if (Main.rand.Next(4) == 0)
                {
                    Item.NewItem((int) npc.position.X, (int) npc.position.Y, npc.width, npc.height,ItemID.Worm, 1, false, 0, false, false);
                }
			}
			if (npc.type == NPCID.Piranha)
            {
                if (Main.rand.Next(50) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExoticBouquet"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.Hellbat)
            {
                if (Main.rand.Next(3) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MagmaGlobule"), Main.rand.Next(20, 40));
                }
			}
			if (npc.type == NPCID.DiggerHead)
            {
                if (Main.rand.Next(30) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Axle"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.GiantBat)
            {
                if (Main.rand.Next(30) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WhackTree"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.BloodCrawler)
            {
                if (Main.rand.Next(12) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Spiderbook"), Main.rand.Next(1, 1));
                }
			}
			if (npc.type == NPCID.TheBride)
            {
                if (Main.rand.Next(1) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ZombieMetal"), Main.rand.Next(1, 8));
                }
			}
			if (npc.type == NPCID.TheGroom)
            {
                if (Main.rand.Next(1) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ZombieMetal"), Main.rand.Next(1, 8));
                }
			}
			if ((double) npc.value > 0.0)
            {
                if (Main.rand.Next(40) == 0 && NPC.downedBoss3 && Main.player[(int) Player.FindClosest(npc.position, npc.width, npc.height)].ZoneMeteor)
                   Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Valhalla"), Main.rand.Next(1, 1));
			}
			if ((double) npc.value > 0.0)
            {
                if (Main.rand.Next(50) == 0 && Main.hardMode && Main.player[(int) Player.FindClosest(npc.position, npc.width, npc.height)].ZoneJungle)
                   Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Elysian"), Main.rand.Next(1, 1));
				}
			}
        }
    }
}
