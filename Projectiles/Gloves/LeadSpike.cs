using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Gloves {
public class LeadSpike : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Lead Spike";
		projectile.width = 6;
		projectile.height = 16;
		projectile.aiStyle = 1;
		projectile.penetrate = 1;
        projectile.timeLeft = 20;
		projectile.melee = true;
		projectile.friendly = true;
	}
}
}	