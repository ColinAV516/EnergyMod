using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.NPCs.Boss.MegaTree
{
    public class MegaTree : ModNPC
    {
		int timer = 0;
		int moveSpeed = 0;
		int moveSpeedY = 0;
		int shootTimer = 0;
        public override void SetDefaults()
        {
            npc.name = "Mega Tree";
            npc.displayName = "Mega Tree";
            npc.aiStyle = -1;
            npc.lifeMax = 3500;
            npc.damage = 40;
            npc.defense = 15;
            npc.knockBackResist = 0f;
            npc.width = 75;
            npc.height = 144;
            npc.value = Item.buyPrice(0, 2, 0, 0);
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noTileCollide = true;
            npc.noGravity = true;
            npc.soundHit = 7;
            npc.soundKilled = 3;
            music = MusicID.Boss2;
			Main.npcFrameCount[npc.type] = 2;
			npc.scale = 1.25f;
			npc.npcSlots = 5;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }

        public override void AI()
        {
			npc.TargetClosest(true);
			npc.spriteDirection = npc.direction;
            Player player = Main.player[npc.target];
            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                 npc.velocity.Y = -20;
				 timer = 0;
            }
			
			timer++;
			if (timer == 3 || timer == 100 || timer == 200 || timer == 300 || timer == 400 || timer == 500)
			{
			Vector2 direction = Main.player[npc.target].Center - npc.Center;
			direction.Normalize();
			npc.velocity.Y = direction.Y * 10f;
			npc.velocity.X = direction.X * 10f;
			}
			
			if (timer == 75 || timer == 175 || timer == 275 || timer == 375 || timer == 475 || timer == 575)
			{
			Vector2 direction = Main.player[npc.target].Center - npc.Center;
			direction.Normalize();
			npc.velocity.Y = direction.Y * 1f;
			npc.velocity.X = direction.X * 1f;
			}
			
			if (timer >= 600 && timer <= 1500)
			{
				if (npc.Center.X >= player.Center.X && moveSpeed >= -100) // flies to players x position
				{
					moveSpeed--;
				}
					
				if (npc.Center.X <= player.Center.X && moveSpeed <= 100)
				{
					moveSpeed++;
				}
				
				npc.velocity.X = moveSpeed * 0.1f;
				
				if (npc.Center.Y >= player.Center.Y - 250f && moveSpeedY >= -35) //Flies to players Y position
				{
					moveSpeedY--;
				}
					
				if (npc.Center.Y <= player.Center.Y - 250f && moveSpeedY <= 35)
				{
					moveSpeedY++;
				}
				
				npc.velocity.Y = moveSpeedY * 0.1f;
				
				shootTimer++;
				if (shootTimer == 50)
				{
				Vector2 direction = Main.player[npc.target].Center - npc.Center;
				direction.Normalize();
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, direction.X * 15f, direction.Y * 15f, mod.ProjectileType("ForestEnergy"), 20, 1, Main.myPlayer, 0, 0);
				shootTimer = 0;
				}
			}
			
			if (timer >= 1500 && !Main.expertMode) //Goes back to phase 1 if not expert
				{
					timer = 0;
				}
				
			if (timer >= 1500 && Main.expertMode) //Phase 3 expert
				{
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 61);      
					Main.dust[dust].scale = 1f;
					npc.velocity.X = 0f;
					npc.velocity.Y = 0f;
					
					if (timer == 1500 || timer == 1700 || timer == 1900 || timer == 2100) //Boss teleports above the player
					{
					int A = Main.rand.Next(-250, 250) * 3;
					int B = Main.rand.Next(-100, 100) - 500;
					npc.position.X = player.Center.X + A;
					npc.position.Y = player.Center.Y + B;
					}
					
				shootTimer++;
				
				if (shootTimer == 20)
					{
						Vector2 direction = Main.player[npc.target].Center - npc.Center;
						direction.Normalize();
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, direction.X * 15f, direction.Y * 15f, mod.ProjectileType("ForestEnergy"), 20, 1, Main.myPlayer, 0, 0);
						shootTimer = 0;
					}
					
					if (timer == 2300) // this is where timer resets on expert mode
					{
						timer = 0;
					}
				}
			
		}
					public override void FindFrame(int frameHeight)
		{
			npc.frameCounter += 0.05f; 
			npc.frameCounter %= Main.npcFrameCount[npc.type]; 
			int frame = (int)npc.frameCounter; 
			npc.frame.Y = frame * frameHeight; 
		}
				public override void NPCLoot()
			{
		if (Main.expertMode)
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (mod.ItemType("MegaTreeBag")));
		}
		else
		{
			int amountToDrop = Main.rand.Next(10,30);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForestEnergy"), amountToDrop);
			
		if (Main.rand.Next(7) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MegaTreeMask"), 1);
            }
		}
	}
        }
    }
