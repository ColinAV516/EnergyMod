using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Boss {
public class LeafAttack : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "LeafAttack";
		projectile.width = 5;
		projectile.height = 5;
		projectile.penetrate = -1;
		projectile.ranged = true;
		projectile.hostile = true;
        projectile.friendly = false;
		projectile.aiStyle = 1;
        projectile.scale = 2f;
	}
}	
}