using ClickerClass;
using ClickerClass.Items;
using ClickerClass.Items.Accessories;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SOTSClickers.Content.Items.Accessories
{
    public class RaspberryMilkCookies : ClickerItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
        }
        public override LocalizedText Tooltip => Tooltip.WithFormatArgs(Milk.DamageIncrease, ChocolateChip.ClickAmount);
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 36;
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 0, 0, 1);
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            ClickerPlayer click = player.GetModPlayer<ClickerPlayer>();
            click.EnableClickEffect(ClickEffect.ChocolateChip);
            click.accCookieItem = Item;
            click.accCookie2 = true;
            click.accGlassOfMilk = true;
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
