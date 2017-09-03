using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Weapons
{
	public class MemorialKnife : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 9;	
			item.melee = true;	
			item.width = 40;		
			item.height = 40;		
			item.useTime = 30;		
			item.useAnimation = 20;		
			item.useStyle = 3;		
			item.knockBack = 2;		
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 1;		
			item.UseSound = SoundID.Item1;	
			item.autoReuse = true;	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ZombieMetal", 6);
		recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
