using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Acessories
{
	public class PowerBattery : ModItem
	{

		public override void SetDefaults()
		{
			item.name = "Power Battery";
			item.width = 22;
			item.height = 20;
			item.toolTip = "80% Increased movement speed and 15% increased melee speed";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}
		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BossEnergy", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.80f;
            player.meleeSpeed += 0.15f;
        }
	}
}