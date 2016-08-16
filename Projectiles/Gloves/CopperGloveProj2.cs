using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Gloves
{
    public class CopperGloveProj2 : ModProjectile
    {
		bool scale = false;
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.name = "Copper Glove";
            projectile.friendly = true;
            projectile.aiStyle = -1;
			projectile.width = 26;
			projectile.height = 26;
			projectile.penetrate = -1;
			projectile.timeLeft = 12;
        }
        		public override void AI()
		{
			projectile.alpha = 0;
			int dust;
			dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 226, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			Main.dust[dust].scale = 0.5f;
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + -5.5f;
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 0f, mod.ProjectileType("CopperGloveProj3"), projectile.damage, 0f, projectile.owner, 0f, 0f);
		}
	
    }
}
