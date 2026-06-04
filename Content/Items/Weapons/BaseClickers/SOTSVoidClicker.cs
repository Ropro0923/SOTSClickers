using System.Collections.Generic;
using Microsoft.Xna.Framework;
using SOTS.Void;
using Terraria.Localization;

namespace SOTSClickers.Content.Items.Weapons.VoidClicker
{
    public abstract class SOTSVoidClicker : VoidItem
    {
        public override LocalizedText Tooltip => Language.GetOrRegister(SOTSClickers.Clicker.GetLocalizationKey("Common.Tooltips.Clicker"));
        public override string Texture => $"SOTSClickers/Assets/Textures/Content/Items/Weapons/VoidClicker/{Name}";
        public virtual void SafeSetStaticDefaults() { }
        public override void SetStaticDefaults()
        {
            ClickerCompat.RegisterClickerWeapon(this);
            CreateEffects();
            SafeSetStaticDefaults();
        }
        public abstract float RadiusWidth { get; }
        public abstract Color RadiusColor { get; }
        public abstract int DustType { get; }
        public virtual List<string>? Effects { get; } = [];
        public abstract void VoidSetDefaults();
        public sealed override void SafeSetDefaults()
        {
            ClickerCompat.SetClickerWeaponDefaults(Item);
            ClickerCompat.SetRadius(Item, RadiusWidth);
            ClickerCompat.SetColor(Item, RadiusColor);
            ClickerCompat.SetDust(Item, DustType);
            Effects?.ForEach(effect => ClickerCompat.AddEffect(Item, effect));
            VoidSetDefaults();
        }
        public virtual void CreateEffects() { }
    }
}