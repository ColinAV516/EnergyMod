using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Night
{
	public class NightSlime : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Night Slime";
			npc.displayName = "Night Slime";
			npc.width = 24;
			npc.height = 18;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 50;
			npc.soundHit = 1;
			npc.soundKilled = 1;
			npc.value = 60f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 1;
			npc.npcSlots = 0.25f;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
			return (tile == 2) && !Main.bloodMoon && spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.2f : 0f;
		}
		
					public override void NPCLoot()
	{
			int amountToDrop = Main.rand.Next(1,5);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, amountToDrop);
					if(Main.rand.Next(20) == 0)
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkEnergy"));
    }
			if(Main.rand.Next(60) == 0)
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("YellowStar"));
    }
	}
	
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	
	}
}
