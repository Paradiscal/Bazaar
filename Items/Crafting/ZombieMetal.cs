using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bazaar.Items.Crafting
{
	public class ZombieMetal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Radioactive Parts");
			Tooltip.SetDefault("'Previously used to raise radiation filled terrors'");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;	
			item.rare = 1;
			item.value = Item.sellPrice(0, 0, 0, 50);
		}
	}
}
