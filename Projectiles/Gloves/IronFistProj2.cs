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
            projectile.magic = true;
            projectile.name = "Iron Fist";
            projectile.friendly = true;
            projectile.aiStyle = 27;
			projectile.width = 16;
			projectile.height = 16;
			projectile.penetrate = -1;
			projectile.timeLeft = 20;
        }
        		public override void AI()
		{
			projectile.alpha = 0;
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
