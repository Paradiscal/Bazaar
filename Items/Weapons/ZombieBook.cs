using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Weapons
{
	public class ZombieBook : ModItem
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Grave Clamp");
        Tooltip.SetDefault("Fires a weak clamp, pushing enemies back");
		}		
        
		public override void SetDefaults()
		{
			item.damage = 9;
			item.magic = true;
	        item.mana = 10;
			item.width = 32;
			item.height = 32;
            item.useAnimation = 25;
			item.channel = true;
            item.useTime = 25;
            item.maxStack = 1;
			item.consumable = false;
            item.useStyle = 5;
            item.autoReuse = true;
            item.noMelee = true;
            item.knockBack = 12f;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 1;
            item.UseSound = SoundID.Item2;
            item.shoot = mod.ProjectileType("Jadehand");
            item.shootSpeed = 10f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
