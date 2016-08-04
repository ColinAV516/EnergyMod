using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Acessories
{
	public class EnergyWings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Wings);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Energy Wings";
			item.width = 22;
			item.height = 20;
			item.toolTip = "Provides a small boost";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 60;
		}

		public override void VerticalWingSpeeds(ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.50f;
			ascentWhenRising = 0.5f;
			maxCanAscendMultiplier = 0.5f;
			maxAscentMultiplier = 1f;
			constantAscend = 0.35f;
		}

		public override void HorizontalWingSpeeds(ref float speed, ref float acceleration)
		{
			speed = 2.5f;
			acceleration *= 3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SoaringEnergy", 15);
			recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}