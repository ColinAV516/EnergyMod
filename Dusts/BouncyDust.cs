using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EnergyMod.Dusts
{
	public class BouncyDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 0.4f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 1.5f;
		}
	}
}