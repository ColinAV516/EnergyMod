using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Night
{
	public class KillerBunny : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Killer Bunny";
			npc.displayName = "Killer Bunny";
			npc.width = 16;
			npc.height = 14;
			npc.damage = 50;
			npc.defense = 10;
			npc.lifeMax = 200;
			npc.soundHit = 7;
			npc.soundKilled = 3;
			npc.value = 300f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 26;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Bunny];
			animationType = NPCID.Bunny;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
			return (tile == 2) && spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.01f : 0f;
		}
		
	
			public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	}
}
