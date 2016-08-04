using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Armor.Dark
{
	public class DarkLeggings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Legs);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Dark Leggings";
			item.width = 18;
			item.height = 18;
			AddTooltip("+20 max life and plus 1 HP/S life regen");
			item.value = 10000;
			item.rare = 2;
			item.defense = 6;
            item.lifeRegen = 1;
		}

		public override void UpdateEquip(Player player)
		{
            player.statLifeMax2 += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkGel", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}