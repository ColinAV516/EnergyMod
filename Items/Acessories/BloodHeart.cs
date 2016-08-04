using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Acessories {
public class BloodHeart : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Blood Heart";
        item.width = 24;
        item.height = 28;
        item.toolTip = "Gives you a chance to steal life on enemy hit";
        item.value = 10000;
        item.rare = 2;
        item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
	{
        ((EnergyPlayer)player.GetModPlayer(mod, "EnergyPlayer")).lifesteal = true;
	}

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "LivingTwig");
        recipe.AddIngredient(null, "ManaStar");
        recipe.AddTile(114);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}