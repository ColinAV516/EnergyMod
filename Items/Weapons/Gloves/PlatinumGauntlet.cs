using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Weapons.Gloves {
	public class PlatinumGauntlet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Platinum Gauntlet";
			item.width = 24;
			item.height = 24;
			item.noUseGraphic = true;
			item.useSound = 1;
			item.melee = true;
			item.noMelee = true;
			item.shootSpeed = 15f;
			item.knockBack = 3.75f;
			item.value = Item.sellPrice(0, 1, 30, 0);
			item.rare = 3;
			item.autoReuse = true;
			item.useStyle = 5;
			item.useTime = 19;
			item.useAnimation = 19;
			item.damage = 17;
			item.shoot = mod.ProjectileType("PlatinumGauntletProj");
		}
	

		public override bool CanUseItem(Player player)
		{
			
			if (player.controlDown)
			{
				item.shootSpeed = 8f;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 12;
				item.shoot = mod.ProjectileType("PlatinumGauntletProj2");
			}
			else
			{
				item.shootSpeed = 15f;
				item.useTime = 19;
				item.useAnimation = 19;
				item.damage = 17;
				item.shoot = mod.ProjectileType("PlatinumGauntletProj");
			}
			return true;
		} 
		
			public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
}}