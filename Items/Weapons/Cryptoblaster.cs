using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Weapons
{
	public class Cryptoblaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cryptoblaster");
			Tooltip.SetDefault("'A zombie's brain, hooked up to a pistol' \nShoot hollowed moons, requiring no ammunition");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 45;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item2;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
            item.shoot = mod.ProjectileType("Cryptogun");
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
