using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Gloves {
public class TinCan : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Tin Can";
		projectile.width = 8;
		projectile.height = 16;
		projectile.aiStyle = 14;
		projectile.penetrate = 2;
        projectile.timeLeft = 500;
		projectile.melee = true;
		projectile.friendly = true;
	}
}
}	