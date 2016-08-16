using System;
using Terraria;
using Terraria.ModLoader;

namespace EnergyMod.Buffs
{
	public class DefensiveStance : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Defensive Stance";
			Main.buffTip[Type] = "+10 defense";
		}
		
				public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += 10;
		}
		
	}
}