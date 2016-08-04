using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Acessories {
public class LivingTwig : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Living Twig";
        item.width = 24;
        item.height = 28;
        item.toolTip = "Increases health by 20";
        item.value = 10000;
        item.rare = 2;
        item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.statLifeMax2 += 20;
	}
}}