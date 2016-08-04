using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Jungle
{
	public class MudMonster : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Mud Monster";
            npc.displayName = "Mud Monster";
			npc.width = 16;
			npc.height = 40;
			npc.damage = 25;
			npc.defense = 10;
			npc.lifeMax = 100;
			npc.soundHit = 1;
			npc.soundKilled = 2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.SwampThing];
			animationType = NPCID.SwampThing;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
            int x = spawnInfo.spawnTileX;
            int y = spawnInfo.spawnTileY;
            int tile = (int)Main.tile[x, y].type;
			return spawnInfo.player.ZoneJungle && spawnInfo.spawnTileY < Main.rockLayer && (tile == 60) && !Main.dayTime ? 0.1f : 0f;
		}
		
			public override void NPCLoot()
	{
        if (Main.rand.Next(60) == 0)
        {
			int amountToDrop = Main.rand.Next(20,40);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Mudball"), amountToDrop);
        }
	}
	
			public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	}
}
