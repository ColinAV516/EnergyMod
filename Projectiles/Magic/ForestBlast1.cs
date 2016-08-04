using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Magic {
public class ForestBlast1 : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Forest Energy";
		projectile.width = 20;
		projectile.height = 20;
		projectile.aiStyle = 0;
		projectile.penetrate = -1;
        projectile.friendly = true;
		projectile.alpha = 100;
		projectile.scale = 1.5f;
		projectile.timeLeft = 60;
	}
	public override bool PreAI()
{
    projectile.rotation += 0.05f;
    return true;
}
    public override void Kill(int timeLeft)
{
          
            
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 10f, 0f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -10f, 0f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 10f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, -10f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -5f, -5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 5f, -5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -5f, 5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 5f, 5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
            
    Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 34);
}
}
}	