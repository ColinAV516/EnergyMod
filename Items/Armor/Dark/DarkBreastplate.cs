using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Armor.Dark
{
	public class DarkBreastplate : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Body);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Dark Breastplate";
			item.width = 18;
			item.height = 18;
			AddTooltip("Plus 20 mana and 1 max minion");
			item.value = 10000;
			item.rare = 2;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 20;
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkGel", 15);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}