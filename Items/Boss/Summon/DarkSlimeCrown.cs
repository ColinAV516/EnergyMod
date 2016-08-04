using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Boss.Summon {
public class DarkSlimeCrown : ModItem
{
public override void SetDefaults()
    {
        item.name = "Dark Slime Crown";
        item.width = 28;
        item.height = 32;
        item.maxStack = 20;
        item.toolTip = "Summons King Night Slime";
        item.rare = 1;
        item.useAnimation = 45;
        item.useTime = 45;
        item.useStyle = 4;
        item.useSound = 0;
        item.consumable = true;
    }
	
	public override bool CanUseItem(Player player)
	{
		return !NPC.AnyNPCs(mod.NPCType("KingNightSlime"));
	}
	
	public override bool UseItem(Player player)
    {
        NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("KingNightSlime"));
        Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
        return true;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "DarkEnergy", 10);
		recipe.AddIngredient(ItemID.SlimeCrown);
		recipe.AddTile(18);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}