using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Gloves
{
    public class PlatinumGauntletProj2 : ModProjectile
    {
		int bounces = 2;
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.name = "Platinum Gauntlet";
            projectile.friendly = true;
            projectile.aiStyle = 2;
			projectile.width = 26;
			projectile.height = 26;
			projectile.penetrate = 5;
        }
		
			public override bool OnTileCollide(Vector2 oldVelocity)
	{
		bounces--;
		if (bounces <= 0)
		{
			projectile.Kill();
		}
       
		if (projectile.velocity.X != oldVelocity.X)
		{
			projectile.velocity.X = -oldVelocity.X;
		}
		if (projectile.velocity.Y != oldVelocity.Y)
		{
			projectile.velocity.Y = -oldVelocity.Y;
		}
		Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
		return false;
	}
	
    }
}
