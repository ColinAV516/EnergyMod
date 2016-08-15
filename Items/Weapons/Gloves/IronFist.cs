using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Weapons.Gloves {
	public class IronFist : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Iron Fist";
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
			item.useTime = 50;
			item.useAnimation = 50;
			item.damage = 7;
			item.shoot = mod.ProjectileType("IronFistProj2");
		}
	

		public override bool CanUseItem(Player player)
		{
			
			if (player.controlDown)
			{
				item.shootSpeed = 14f;
				item.useTime = 50;
				item.useAnimation = 50;
				item.damage = 10;
				item.shoot = mod.ProjectileType("IronFistProj2");
			}
			else
			{
				item.shootSpeed = 15f;
				item.useTime = 7;
				item.useAnimation = 7;
				item.damage = 6;
				item.shoot = mod.ProjectileType("IronFistProj");
			}
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			if (player.controlUp)
			{
				Terraria.Projectile.NewProjectile(position.X, position.Y, 0f, 5f, type, damage, knockBack, player.whoAmI, 0f, 0f);
				player.velocity.Y = -15f;
				return false;
			}
			return true;
        }  
}}