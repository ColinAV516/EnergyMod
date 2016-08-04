using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Boss.KingNightSlime {
public class KingNightSlime : ModNPC 
{
	public override void SetDefaults()
	{
		npc.name = "King Night Slime";
		npc.displayName = "King Night Slime";
        npc.aiStyle = 15;
        npc.lifeMax = 3000;
        npc.damage = 45;
        npc.defense = 10;
        npc.knockBackResist = 0f;
        npc.width = 174;
        npc.height = 120;
        Main.npcFrameCount[npc.type] = 6;
		animationType = NPCID.KingSlime;
        npc.npcSlots = 5;
        npc.boss = true;
        npc.soundHit = 1;
        npc.soundKilled = 1;
        music = 12;
	}
	
	public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
		npc.damage = (int)(npc.damage * 0.6f);
	}
	
		public override void AI()
	{
			if (Main.rand.Next(500) == 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("GelWarp"));
			}	
			if (Main.rand.Next(300) == 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("NightSlime"));
			}
					if (Main.expertMode)
		{
			if (Main.rand.Next(500) == 0)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("NightBat"));
			}	
		}
	}
		public override void NPCLoot()
	{
		if (Main.expertMode)
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (mod.ItemType("NightSlimeBag")));
		}
		else
		{
			int amountToDrop = Main.rand.Next(15,30);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkGel"), amountToDrop);

            if (Main.rand.Next(2) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkGelStabilizer"), 1);
            }
            if (Main.rand.Next(2) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NightSpiral"), 1);
            }
            if (Main.rand.Next(2) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkSlimeStaff"), 1);
            }
		}
	}
}}