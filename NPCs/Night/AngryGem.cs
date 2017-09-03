using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.NPCs.Night
{
	public class AngryGem : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Necrotic Gemstone");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 16;
			npc.height = 16;
			npc.damage = 30;
			npc.defense = 5;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath7;
			npc.value = 60f;
			npc.aiStyle = 14;
			animationType = NPCID.GiantBat;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			banner = npc.type;
			bannerItem = mod.ItemType("AngryGemBannerItem");
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.015f;
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(14) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GemstoneAnger"), Main.rand.Next(1, 1));
			}
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ZombieMetal"), Main.rand.Next(1, 3));
			}
		}
	}
}
