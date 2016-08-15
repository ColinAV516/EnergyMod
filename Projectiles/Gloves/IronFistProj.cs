using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Projectiles.Gloves
{
    public class IronFistProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.name = "Iron Fist";
            projectile.friendly = true;
            projectile.aiStyle = 27;
			projectile.width = 16;
			projectile.height = 16;
			projectile.penetrate = 1;
			projectile.timeLeft = 10;
        }
        		public override void AI()
		{
			projectile.alpha = 0;
		}
	
    }
}
