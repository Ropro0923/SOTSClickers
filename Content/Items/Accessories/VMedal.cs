using ClickerClass.Items;
using Terraria;
using SOTSClickers.Common.Utilities;
using ClickerClass;

namespace SOTSClickers.Content.Items.Accessories
{
    public class VMedal : ClickerItem
    {
        public override string Texture => "SOTSClickers/Assets/Textures/Content/Items/Accessories/VMedal";
        public static readonly int ChargeMeterMax = 300; // grr
        public static readonly int ChargeMeterStep = ChargeMeterMax / 15;
        public static readonly int VoidRecovery = 2;
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.SOTSClickerPlayer().accVMedalItem = Item;
            player.GetModPlayer<ClickerPlayer>().accSMedalItem = Item;
        }
    }
}