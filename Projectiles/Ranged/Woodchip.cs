using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Ranged {
public class Woodchip : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Woodchip";
		projectile.width = 5;
		projectile.height = 5;
		projectile.penetrate = 1;
		projectile.ranged = true;
		projectile.friendly = true;
		projectile.aiStyle = 1;
        projectile.timeLeft = 90;
	}


}	
}