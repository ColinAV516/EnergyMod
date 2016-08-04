using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Weapons.Dark {
public class CrimtaneStabber : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Crimtane Stabber";
        item.damage = 13;
        item.melee = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 13;
        item.useAnimation = 13;
        item.useStyle = 3;
        item.knockBack = 1;
        item.value = 10000;
        item.rare = 1;
        item.useSound = 1;
        item.autoReuse = true;
		item.toolTip = "Stabs extremely fast";
    }
	
			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkEnergy", 10);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}