using Terraria.ModLoader;

namespace Bazaar
{
	class Bazaar : Mod
	{
		public Bazaar()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
