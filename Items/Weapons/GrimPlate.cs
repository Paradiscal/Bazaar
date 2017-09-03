using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Weapons
{
	public class GrimPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Grim Plate");
		}		
        
		public override void SetDefaults()
		{
			item.damage = 13;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
            item.useAnimation = 25;
            item.useTime = 25;
            item.maxStack = 999;
			item.consumable = true;
            item.useStyle = 1;
            item.autoReuse = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.knockBack = 3f;
            item.value = Item.sellPrice(0, 0, 0, 1);
			item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("GrimPlate");
            item.shootSpeed = 10f;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 6);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 333);
            recipe.AddRecipe();
        }
	}
}
