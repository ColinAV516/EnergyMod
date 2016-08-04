using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Acessories {
public class LifeTwig : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Twig of Life";
        item.width = 24;
        item.height = 28;
        item.toolTip = "Increases health by 40";
        item.value = 10000;
        item.rare = 2;
        item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.statLifeMax2 += 40;
	}

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "LivingTwig");
        recipe.AddIngredient(ItemID.BandofRegeneration, 1);
        recipe.AddTile(114);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}