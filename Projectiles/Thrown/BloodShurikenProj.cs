using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Thrown {
public class BloodShurikenProj : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Blood Shuriken";
		projectile.width = 20;
		projectile.height = 20;
		projectile.aiStyle = 2;
		projectile.penetrate = 3;
		projectile.thrown = true;
		projectile.friendly = true;
	}
	public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	{
			Player player = Main.player[projectile.owner];
			player.HealEffect(1);
			player.statLife += 1;
	}
}
}	