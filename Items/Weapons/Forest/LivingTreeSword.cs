using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Weapons.Forest {
public class LivingTreeSword : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Living Tree Sword";
        item.damage = 55;
        item.melee = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 60;
        item.useAnimation = 60;
        item.useStyle = 1;
        item.knockBack = 3;
        item.value = 10000;
        item.rare = 1;
        item.useSound = 1;
        item.autoReuse = true;
		item.toolTip = "Swings Slow, but hits heavily";
		item.scale = 1.3f;
    }
	

	
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForestEnergy", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}