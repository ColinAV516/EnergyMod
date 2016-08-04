using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Weapons.Forest
{
	public class TreeStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tree Staff";
			item.damage = 17;
			item.summon = true;
			item.mana = 10;
			item.width = 26;
			item.height = 28;
			item.toolTip = "Summons a ghastly tree to fight for you";
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 0;
			item.rare = 2;
			item.useSound = 44;
			item.shoot = mod.ProjectileType("TreeMinion");
			item.shootSpeed = 20f;
			item.buffType = mod.BuffType("TreeMinion");
			item.buffTime = 3600;
			item.expert = true;
		}
	}
}