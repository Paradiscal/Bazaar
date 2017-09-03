using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Bazaar.Items.Ammo
{
    public class DeadArrow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leech Arrow");
        Tooltip.SetDefault("Has minimal damage, but insane knockback");

        }
        public override void SetDefaults()
		{
			
			item.width = 10;
			item.height = 28;
            item.value = 1;
            item.rare = 1;

            item.maxStack = 999;

            item.damage = 2;
			item.knockBack = 18f;
            item.ammo = AmmoID.Arrow;

            item.ranged = true;
            item.consumable = true;

            item.shoot = mod.ProjectileType("DeadArrow");
            item.shootSpeed = 2.5f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 3);
                      recipe.AddTile(16);
            recipe.SetResult(this, 99);
            recipe.AddRecipe();
        }
    }
}
