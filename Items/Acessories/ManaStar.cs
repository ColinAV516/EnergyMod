using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Acessories {
public class ManaStar : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Mana Star";
        item.width = 24;
        item.height = 28;
        item.toolTip = "Increased maximum mana by 40";
        item.value = 10000;
        item.rare = 2;
        item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.statManaMax2 += 40;
	}
	
			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "YellowStar");
			recipe.AddIngredient(ItemID.BandofStarpower, 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}