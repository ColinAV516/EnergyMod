using System;
using Terraria;
using Terraria.ModLoader;

namespace EnergyMod.Buffs
{
	public class OffensiveStance : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Offensive Stance";
			Main.buffTip[Type] = "30% increased melee damage";
		}
		
				public override void Update(Player player, ref int buffIndex)
		{
			player.meleeDamage += 0.30f;
		}
		
	}
}