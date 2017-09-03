using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Accessories
{
    public class NightEye : ModItem
    {
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Animalistic Eye");
        Tooltip.SetDefault("'Its looking at you...' \nIncreases minion slots by 1");
		}		
		
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
			item.value = 1000;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        { 
            player.maxMinions++;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 5);
            recipe.AddIngredient(ItemID.Lens, 2);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}