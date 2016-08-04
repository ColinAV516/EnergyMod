using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Materials
{
	public class DarkGel : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dark Gel";
			item.width = 10;
			item.height = 10;
			item.noMelee = true; 
			item.value = 10000;
			item.rare = 2;
			item.scale = 0.75f;
			item.maxStack = 999;
		}
}
}