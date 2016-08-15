using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Gloves {
public class IronSpike : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Iron Spike";
		projectile.width = 14;
		projectile.height = 14;
		projectile.aiStyle = 14;
		projectile.penetrate = 1;
        projectile.timeLeft = 200;
		projectile.thrown = true;
		projectile.friendly = true;
	}
}
}	