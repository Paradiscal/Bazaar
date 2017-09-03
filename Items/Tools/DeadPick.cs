using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Tools
{
	public class DeadPick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dead Sledge");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 11;
			item.useAnimation = 19;
			item.pick = 45;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.sellPrice(0, 0, 3, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 12);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
