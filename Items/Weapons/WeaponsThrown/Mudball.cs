using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Weapons.WeaponsThrown {
public class Mudball : ModItem
{
	
    public override void SetDefaults()
    {
        item.name = "Mudball";
        item.damage = 17;
        item.thrown = true;
		item.noMelee = true;
		item.noUseGraphic = true;
        item.width = 22;
        item.height = 22;
        item.toolTip = "Throws a mud ball";
        item.useTime = 20;
        item.useAnimation = 20;
        item.useStyle = 1;
		item.shootSpeed = 10f;
		item.shoot = mod.ProjectileType("MudballProj");
        item.knockBack = 1;
		item.useSound = 1;
		item.scale = 1f;
        item.value = 10000;
        item.rare = 1;
        item.useSound = 1;
        item.autoReuse = true;
		item.consumable = true;
        item.maxStack = 999;
    }
}}