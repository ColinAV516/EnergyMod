using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Armor.Dark
{
	public class DarkHood : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Dark Hood";
			item.width = 18;
			item.height = 18;
			item.toolTip = "10% increased melee and movement speed";
			item.value = 10000;
			item.rare = 2;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("DarkBreastplate") && legs.type == mod.ItemType("DarkLeggings");
		}

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.10f;
            player.meleeSpeed += 0.10f;
        }

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases damage by 10%";
            player.meleeDamage += 0.1f;
            player.thrownDamage += 0.1f;
            player.rangedDamage += 0.1f;
            player.magicDamage += 0.1f;
            player.minionDamage += 0.1f;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DarkGel", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}