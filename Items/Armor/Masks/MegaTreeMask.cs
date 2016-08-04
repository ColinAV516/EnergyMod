using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod.Items.Armor.Masks
{
	public class MegaTreeMask : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Mega Tree Mask";
			item.width = 18;
			item.height = 18;
			item.vanity = true;
			item.value = 10000;
			item.rare = 2;
		}

	}
}