using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Boss.KingNightSlime
{
	public class GelWarp : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Gel Warp";
			npc.displayName = "Gel Warp";
			npc.width = 32;
			npc.height = 32;
			npc.damage = 0;
			npc.defense = 10;
			npc.lifeMax = 30;
			npc.soundHit = 1;
			npc.soundKilled = 1;
			npc.value = 60f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 14;
			npc.npcSlots = 0.25f;
			aiType = NPCID.GiantBat;
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
	}
	
			public override void AI()
	{
			if (Main.rand.Next(2000) == 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.SpikedIceSlime);
			}	
			if (Main.rand.Next(1000) == 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.SlimeSpiked);
			}
					if (Main.expertMode)
		{
			if (Main.rand.Next(2000) == 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.SpikedJungleSlime);
			}	
		}
	}
	}
}
