using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Thrown {
public class MudballProj : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Mudball";
		projectile.width = 14;
		projectile.height = 14;
		projectile.aiStyle = 14;
		projectile.penetrate = 1;
        projectile.timeLeft = 300;
		projectile.thrown = true;
		projectile.friendly = true;
	}
}
}	