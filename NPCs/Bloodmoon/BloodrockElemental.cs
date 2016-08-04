using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Bloodmoon
{
	public class BloodrockElemental : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Bloodrock Elemental";
			npc.displayName = "Bloodrock Elemental";
			npc.width = 20;
			npc.height = 30;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 25;
			npc.soundHit = 7;
			npc.soundKilled = 6;
			npc.value = 60f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 91;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[483];
			aiType = 483;
			animationType = 483;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			return Main.bloodMoon && spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.1f : 0f;
		}
		
	public override void NPCLoot()
	{
		if(Main.rand.Next(60) == 0)
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodHeart"));
    }
	}
	
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	
	}
}
