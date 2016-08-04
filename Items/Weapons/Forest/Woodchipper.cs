using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Weapons.Forest {
public class Woodchipper : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Wood Chipper";
        item.damage = 7;
        item.ranged = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 5;
        item.useAnimation = 20;
		item.useSound = 22;
        item.useStyle = 5;
        item.knockBack = 3;
        item.value = 10000;
        item.rare = 1;
        item.autoReuse = true;
		item.toolTip = "Shoots tiny pieces of wood";
        item.shoot = mod.ProjectileType("Woodchip");
        item.shootSpeed = 10f;
    }

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        int amountOfProjectiles = 2;
        for (int i = 0; i < amountOfProjectiles; ++i)
        {
            float sX = speedX;
            float sY = speedY;
            sX += (float)Main.rand.Next(-60, 61) * 0.02f;
            sY += (float)Main.rand.Next(-60, 61) * 0.02f;
            Projectile.NewProjectile(position.X, position.Y, sX, sY, type, damage, knockBack, player.whoAmI);
        }
        return false;
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