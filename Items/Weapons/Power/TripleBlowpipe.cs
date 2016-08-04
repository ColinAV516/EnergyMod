using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Weapons.Power {
public class TripleBlowpipe : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Triple Blowpipe";
        item.damage = 12;
        item.ranged = true;
        item.width = 40;
        item.height = 20;
        item.toolTip = "Uses seeds or darts as ammo";
        item.useTime = 60;
        item.useAnimation = 60;
        item.useStyle = 5;
        item.noMelee = true; 
        item.knockBack = 4;
        item.value = 10000;
        item.rare = 2;
        item.useSound = 5;
        item.autoReuse = true;
        item.shoot = 51; 
        item.shootSpeed = 10f;
        item.useAmmo = ProjectileID.Seed;
    }


    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        int amountOfProjectiles = 3;
        for (int i = 0; i < amountOfProjectiles; ++i)
        {
            float sX = speedX;
            float sY = speedY;
            sX += (float)Main.rand.Next(-60, 61) * 0.05f;
            sY += (float)Main.rand.Next(-60, 61) * 0.05f;
            Projectile.NewProjectile(position.X, position.Y, sX, sY, type, damage, knockBack, player.whoAmI);
        }
        return false;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "BossEnergy", 2);
        recipe.AddIngredient(ItemID.Topaz, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}