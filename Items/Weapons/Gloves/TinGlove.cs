using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Weapons.Gloves {
	public class TinGlove : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tin Glove";
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
			item.useTime = 7;
			item.useAnimation = 7;
			item.damage = 5;
			item.shoot = mod.ProjectileType("TinGloveProj2");
		}
	

		public override bool CanUseItem(Player player)
		{
			
			if (player.controlDown)
			{
				item.shootSpeed = 14f;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 10;
				item.shoot = mod.ProjectileType("TinGloveProj2");
			}
			else
			{
				item.shootSpeed = 15f;
				item.useTime = 7;
				item.useAnimation = 7;
				item.damage = 5;
				item.shoot = mod.ProjectileType("TinGloveProj");
			}
			return true;
		}
}}