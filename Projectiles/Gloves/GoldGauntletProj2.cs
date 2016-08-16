using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Gloves
{
    public class GoldGauntletProj2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.name = "Gold Gauntlet";
            projectile.friendly = true;
            projectile.aiStyle = 3;
			projectile.width = 26;
			projectile.height = 26;
			projectile.penetrate = -1;
			projectile.timeLeft = 2000;
        }
	
    }
}
