using ClickerClass.Items;
using ClickerClass.Items.Accessories;
using ClickersOfTheShadows.Common.Utilities;
using SOTS.Items.Conduit;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Content.Items.Accessories
{
    public class WrathCookie : ClickerItem
    {
        public override string Texture => $"ClickersOfTheShadows/Assets/Textures/Content/Items/Accessories/{Name}";
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.CotSPlayer().accWrathCookie = Item;
            ModContent.GetInstance<Cookie>().UpdateAccessory(player, hideVisual);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Cookie>()
                .AddIngredient<SkipSoul>(5)
                .AddTile(TileID.TinkerersWorkbench)
            .Register();
        }
    }
}
