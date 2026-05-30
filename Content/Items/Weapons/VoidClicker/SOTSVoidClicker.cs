using System.Collections.Generic;
using Microsoft.Xna.Framework;
using ClickerClass;
using SOTS.Void;
using Terraria;
using Terraria.Localization;

namespace SOTSClickers.Content.Items.Weapons.VoidClicker
{
    public abstract class SOTSVoidClicker : VoidItem
    {
        public override LocalizedText Tooltip => Language.GetOrRegister(SOTSClickers.Clicker.GetLocalizationKey("Common.Tooltips.Clicker"));
        public override string Texture => "SOTSClickers/Assets/Textures/Content/Items/Weapons/VoidClicker/" + Name;

        public abstract float RadiusWidth { get; }
        public abstract Color RadiusColor { get; }
        public abstract int DustType { get; }
        public virtual List<string>? Effects { get; } = [];

        public virtual void SafeSetStaticDefaults() { }
        public sealed override void SetStaticDefaults()
        {
            ClickerSystem.RegisterClickerWeapon(this, borderTexture: Texture + "_Outline");
            CreateEffects();
            SafeSetStaticDefaults();
        }

        public virtual void VoidSafeSetDefaults() { }
        public sealed override void SafeSetDefaults()
        {
            ClickerCompat.SetClickerWeaponDefaults(Item);
            ClickerCompat.SetRadius(Item, RadiusWidth);
            ClickerCompat.SetColor(Item, RadiusColor);
            ClickerCompat.SetDust(Item, DustType);
            Effects?.ForEach(effect => ClickerCompat.AddEffect(Item, effect));
            Item.DamageType = Core.DamageClasses.VoidClicker.Instance;

            VoidSafeSetDefaults();
        }
        public virtual void CreateEffects() { }
    }
}