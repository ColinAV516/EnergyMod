using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Gloves {
public class CopperGloveProj3 : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Lightning";
		projectile.width = 200;
		projectile.height = 200;
		projectile.aiStyle = -1;
		projectile.penetrate = -1;
        projectile.timeLeft = 1;
		projectile.melee = true;
		projectile.friendly = true;
		projectile.alpha = 255;
	}
	
	     public override void AI()
		{
			int amountOfDust = 20;
			for (int i = 0; i < amountOfDust; ++i)
			{
				int dust;
				dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 226, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Main.dust[dust].scale = 1.5f;
				projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + -5.5f;
			}
		}
}
}	