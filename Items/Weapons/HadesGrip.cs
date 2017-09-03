
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Weapons
{
	public class HadesGrip : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 10;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 38;
			item.shootSpeed = 3.7f;
			item.knockBack = 4f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.HadesGrip>();
			item.value = 100;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.melee = true;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 8);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}