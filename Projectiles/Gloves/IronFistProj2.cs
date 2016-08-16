using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Gloves
{
    public class IronFistProj2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.name = "Iron Fist";
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
			Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -5f, -5f, mod.ProjectileType("IronSpike"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 5f, -5f, mod.ProjectileType("IronSpike"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -5f, 5f, mod.ProjectileType("IronSpike"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 5f, 5f, mod.ProjectileType("IronSpike"), projectile.damage, 0f, projectile.owner, 0f, 0f);
		}
	
    }
}
