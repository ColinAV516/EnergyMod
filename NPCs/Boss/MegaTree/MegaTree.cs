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
		int shootTimerB = 0;
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
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/MegaTree");
			Main.npcFrameCount[npc.type] = 2;
			npc.scale = 1.25f;
			npc.npcSlots = 5;
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
			
			
			if (!Main.expertMode || npc.life >= 3000)
			{
				if (timer == 3 || timer == 100 || timer == 200 || timer == 300 || timer == 400 || timer == 500)
				{
					npc.alpha = 0;
					moveSpeed = 0;
					moveSpeedY = 0;
					Vector2 direction = Main.player[npc.target].Center - npc.Center;
					direction.Normalize();
					npc.velocity.Y = direction.Y * 10f;
					npc.velocity.X = direction.X * 10f;
				}
			
				if (timer == 75 || timer == 175 || timer == 275 || timer == 375 || timer == 475)
				{
					Vector2 direction = Main.player[npc.target].Center - npc.Center;
					direction.Normalize();
					npc.velocity.Y = direction.Y * 1f;
					npc.velocity.X = direction.X * 1f;
				}
			}
			else
			{
				if (timer == 3 || timer == 50 || timer == 100 || timer == 150 || timer == 200 || timer == 250 || timer == 300 || timer == 350 || timer == 400 || timer == 450 || timer == 500 || timer == 550)
				{
					npc.alpha = 150;
					moveSpeed = 0;
					moveSpeedY = 0;
					Vector2 direction = Main.player[npc.target].Center - npc.Center;
					direction.Normalize();
					npc.velocity.Y = direction.Y * 13f;
					npc.velocity.X = direction.X * 13f;
				}
			
				if (timer == 40 || timer == 90 || timer == 140 || timer == 190 || timer == 240 || timer == 290 || timer == 340 || timer == 390 || timer == 440 || timer == 490 || timer == 540)
				{
					Vector2 direction = Main.player[npc.target].Center - npc.Center;
					direction.Normalize();
					npc.velocity.Y = direction.Y * 1f;
					npc.velocity.X = direction.X * 1f;
				}
			}
			
			
			
			if (timer >= 600 && timer <= 1500)
			{
				if (npc.Center.X >= player.Center.X && moveSpeed >= -50) // flies to players x position
				{
					moveSpeed--;
				}
					
				if (npc.Center.X <= player.Center.X && moveSpeed <= 50)
				{
					moveSpeed++;
				}
				
				if (!Main.expertMode || npc.life >= 3000) //Moves faster on expert
				{
					npc.velocity.X = moveSpeed * 0.2f;
				}
				else
				{
					npc.velocity.X = moveSpeed * 0.3f;	
				}
				
				if (npc.Center.Y >= player.Center.Y - 250f && moveSpeedY >= -35) //Flies to players Y position
				{
					moveSpeedY--;
				}
					
				if (npc.Center.Y <= player.Center.Y - 250f && moveSpeedY <= 35)
				{
					moveSpeedY++;
				}
				
				if (!Main.expertMode || npc.life >= 3000) //Moves faster on expert
				{
					npc.velocity.Y = moveSpeedY * 0.1f;
				}
				else
				{
					npc.velocity.Y = moveSpeedY * 0.15f;
				}
				
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
					npc.velocity.X = 0f;
					npc.velocity.Y = 0f;
					npc.alpha = 100;
					if (Main.expertMode && npc.life <= 3000)
				{
					npc.alpha = 200;
				}
					
				shootTimerB++;
				
				
				if (shootTimerB == 30)
					{
						for (int i = 0; i < 50; ++i)
						{
						int dust = Dust.NewDust(npc.position, npc.width, npc.height, 61);      
						Main.dust[dust].scale = 1.5f;
						}
						int A = Main.rand.Next(-250, 250) * 3;
						int B = Main.rand.Next(-100, 100) - 500;
						npc.position.X = player.Center.X + A;
						npc.position.Y = player.Center.Y + B;
						Vector2 direction = Main.player[npc.target].Center - npc.Center;
						direction.Normalize();
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, direction.X * 15f, direction.Y * 15f, mod.ProjectileType("ForestEnergy"), 20, 1, Main.myPlayer, 0, 0);
						shootTimerB = 0;
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
