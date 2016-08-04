using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnergyMod
{
	public class EnergyPlayer : ModPlayer
	{
		public bool vampireMinion = false;
        public bool darkMinion = false;
        public bool powerMinion = false;
		public bool treeMinion = true;
        public bool lifesteal = false;
		public bool darkshot = false;
			public override void ResetEffects()
		{
			vampireMinion = false;
            darkMinion = false;
            powerMinion = false;
			treeMinion = false;
            lifesteal = false;
			darkshot = false;
		}
		

            public override void OnHitAnything(float x, float y, Entity victim)
            {
                if (Main.rand.Next(15) == 0 && lifesteal == true)
                {
                    player.HealEffect(1);
                    player.statLife += 1;
                }
            }
		}
	}