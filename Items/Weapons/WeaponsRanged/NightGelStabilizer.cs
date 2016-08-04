using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Weapons.WeaponsRanged {
public class NightGelStabilizer : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Night Gel Stabilizer";
        item.damage = 20;
        item.ranged = true;
        item.width = 50;
        item.height = 50;
        item.useTime = 13;
        item.useAnimation = 13;
        item.useStyle = 5;
        item.knockBack = 5;
        item.value = 10000;
        item.rare = 2;
        item.useSound = 13;
        item.autoReuse = true;
		item.shoot = mod.ProjectileType("DarkGelShot");
		item.shootSpeed = 15f;
		item.noMelee = true;
        item.scale = 0.9f;
    }
}}