using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.NPCs.Night
{
	public class  ZombieHead : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Undead Goophead");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.width = 16;
			npc.height = 16;
			npc.damage = 15;
			npc.defense = 2;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.aiStyle = 1; 
			animationType = NPCID.BlueSlime;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			banner = npc.type;
			bannerItem = mod.ItemType("ZombieHeadBannerItem");
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.08f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/NuclearPart"), 1f);
				for (int k = 0; k < 8; k++)
				{
				}
			}
		}
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ZombieMetal"), Main.rand.Next(1, 8));
			}
		}
	}
}
