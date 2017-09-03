using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Accessories
{
    public class GemstoneAnger : ModItem
    {
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Anger Jewel");
        Tooltip.SetDefault("'Shines with malevolence' \nIncreases minion slots by 1");
		}		
		
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
			item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        { 
            player.maxMinions++;
        }
    }
}