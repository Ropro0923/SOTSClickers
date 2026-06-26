using SOTSClickers.Common.Utilities;
using Terraria;
using Terraria.UI;

namespace SOTSClickers.Content.UI
{
    internal class VMedalGauge : MedalGaugeBase
    {
        public VMedalGauge() : base("SOTSClickers: V Medal Gauge", InterfaceScaleType.UI) { }
        protected override int GetValue() => Main.LocalPlayer.SOTSClickerPlayer().accVMedalAmount;
        protected override int TextColor() => Terraria.ID.ItemRarityID.Purple;
        protected override string TexturePath => "VMedalGauge_Sheet";
    }
}
