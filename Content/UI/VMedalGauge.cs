using ClickersOfTheShadows.Common.Utilities;
using Terraria;
using Terraria.UI;

namespace ClickersOfTheShadows.Content.UI
{
    internal class VMedalGauge : MedalGaugeBase
    {
        public VMedalGauge() : base("ClickersOfTheShadows: V Medal Gauge", InterfaceScaleType.UI) { }
        protected override int GetValue() => Main.LocalPlayer.CotSPlayer().accVMedalAmount;
        protected override int TextColor() => Terraria.ID.ItemRarityID.Purple;
        protected override string TexturePath => "VMedalGauge_Sheet";
    }
}
