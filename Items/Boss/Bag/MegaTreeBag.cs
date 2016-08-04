using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Boss.Bag
{
	public class MegaTreeBag : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Treasure Bag";
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.toolTip = "Right click to open";
			item.expert = true;
			bossBagNPC = mod.NPCType("MegaTree");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			int amountToDrop = Main.rand.Next(20,30);
			player.QuickSpawnItem(mod.ItemType("ForestEnergy"), amountToDrop);
                player.QuickSpawnItem(mod.ItemType("TreeStaff"), 1);
				
				if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("MegaTreeMask"), 1);
            }
		}
	}
}