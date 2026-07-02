using ClickerClass.Items;
using ClickerClass.Items.Accessories;
using ClickersOfTheShadows.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Content.Items.Accessories
{
    public class RaspberryMilkCookies : ClickerItem
    {
        //    public override bool IsLoadingEnabled(Mod mod) => false;
        public override string Texture => $"ClickersOfTheShadows/Assets/Textures/Content/Items/Accessories/{Name}";
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Milk.DamageIncrease, ChocolateChip.ClickAmount);
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 36;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            ModContent.GetInstance<ChocolateMilkCookies>().UpdateAccessory(player, hideVisual);
            player.ClickersOfTheShadowsClickerPlayer().accRaspberryMilkCookies = Item;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ChocolateMilkCookies>()
                .AddTile(TileID.TinkerersWorkbench)
            .Register();
        }
    }
}
