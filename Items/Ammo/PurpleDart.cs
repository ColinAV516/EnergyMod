using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnergyMod.Items.Ammo {
public class PurpleDart : ModItem
{
	
    public override void SetDefaults()
    {
        item.name = "Purple Dart";
        item.damage = 5;
        item.ranged = true;
        item.width = 22;
        item.height = 22;
        item.toolTip = "Shot out of blowpipes, explodes on contact";
		item.shootSpeed = 2f;
		item.shoot = mod.ProjectileType("PurpleDartProj");
        item.knockBack = 1;
		item.useSound = 1;
		item.scale = 1f;
        item.value = 10000;
        item.rare = 1;
		item.expert = true;
        item.ammo = ProjectileID.Seed;
    }
}}