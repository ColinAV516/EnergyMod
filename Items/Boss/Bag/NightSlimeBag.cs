using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Boss.Bag
{
	public class NightSlimeBag : ModItem
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
			bossBagNPC = mod.NPCType("KingNightSlime");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			int amountToDrop = Main.rand.Next(20,30);
			player.QuickSpawnItem(mod.ItemType("DarkGel"), amountToDrop);
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("NightGelStabilizer"), 1);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("NightSpiral"), 1);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("DarkSlimeStaff"), 1);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("PurpleDart"), 1);
            }
		}
	}
}