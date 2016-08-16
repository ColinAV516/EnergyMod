using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Gloves
{
    public class LeadFistProj2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.name = "Lead Fist";
            projectile.friendly = true;
            projectile.aiStyle = -1;
			projectile.width = 26;
			projectile.height = 26;
			projectile.penetrate = -1;
			projectile.timeLeft = 12;
        }
        		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + -5.5f;
		}
		
		public override void Kill(int timeLeft)
		{
			 int amountOfProjectiles = 3;
			for (int i = 0; i < amountOfProjectiles; ++i)
			{
				float sX = projectile.velocity.X;
				float sY = projectile.velocity.Y;
				sX += (float)Main.rand.Next(-60, 61) * 0.05f;
				sY += (float)Main.rand.Next(-60, 61) * 0.05f;
				Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX * 0.5f, sY * 0.5f, mod.ProjectileType("LeadSpike"), projectile.damage, 0f, projectile.owner, 0f, 0f);
			}
		}
	
    }
}
