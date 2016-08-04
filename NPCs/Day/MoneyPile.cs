using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Day
{
	public class MoneyPile : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Money Pile";
			npc.displayName = "Money Pile";
			npc.width = 40;
			npc.height = 18;
			npc.damage = 15;
			npc.defense = 20;
			npc.lifeMax = 400;
			npc.soundHit = 1;
			npc.soundKilled = 1;
			npc.value = 60f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 1;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
            return spawnInfo.spawnTileY < Main.rockLayer ? 0.0001f : 0f;
		}
		
					public override void NPCLoot()
	{
			int amountToDrop = Main.rand.Next(5,20);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldCoin, amountToDrop);
	}
	
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	
	}
}
