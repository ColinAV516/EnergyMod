using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Projectiles.Ranged {
public class LeechingArrow : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Leeching Arrow";
		projectile.width = 10;
		projectile.height = 10;
		projectile.penetrate = 1;
		projectile.ranged = true;
		projectile.friendly = true;
		projectile.alpha = 0;
		projectile.aiStyle = 1;
	}
	
	public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	{
	Player player = Main.player[projectile.owner];
	player.HealEffect(2);
	player.statLife += 2;
	}
}	
}