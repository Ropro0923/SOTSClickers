using ClickerClass.Prefixes.ClickerPrefixes;
using SOTS;
using ClickersOfTheShadows.Content.Items.Weapons.VoidClicker;
using Terraria;

namespace ClickersOfTheShadows.Content.Prefixes
{
    public class FamishedClicker : ClickerPrefix
    {
        public FamishedClicker() : base(0.9f, 0, 0, 0)
        {

        }
        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 0.9f;
        }
        public override bool CanRoll(Item item) => item.ModItem is ClickersOfTheShadowsVoidClicker;
        public override void Apply(Item item)
        {
            base.Apply(item);
            item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 1.1f;
        }
    }
    public class PrecariousClicker : ClickerPrefix
    {
        public PrecariousClicker() : base(1.1f, 0, 0, 0)
        {

        }
        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.03f;
        }
        public override bool CanRoll(Item item) => item.ModItem is ClickersOfTheShadowsVoidClicker;
        public override void Apply(Item item)
        {
            base.Apply(item);
            item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 1.2f;
        }
    }
    public class PotentClicker : ClickerPrefix
    {
        public PotentClicker() : base(1.05f, 0, 0, 0)
        {

        }
        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.07f;
        }
        public override bool CanRoll(Item item) => item.ModItem is ClickersOfTheShadowsVoidClicker;
        public override void Apply(Item item)
        {
            base.Apply(item);
            item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 0.9f;
        }
    }
    public class OmnipotentClicker : ClickerPrefix
    {
        public OmnipotentClicker() : base(1.15f, 0, 0, 5)
        {

        }
        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.16f;
        }
        public override bool CanRoll(Item item) => item.ModItem is ClickersOfTheShadowsVoidClicker;
        public override void Apply(Item item)
        {
            base.Apply(item);
            item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 0.9f;
        }
    }
    public class ChthonicClicker : ClickerPrefix
    {
        public ChthonicClicker() : base(1.24f, 0, 0, 5)
        {

        }
        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.06f;
        }
        public override bool CanRoll(Item item) => item.ModItem is ClickersOfTheShadowsVoidClicker;
        public override void Apply(Item item)
        {
            base.Apply(item);
            item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 1.1f;
        }
    }
}