using System.Collections.Generic;
using Microsoft.Xna.Framework;
using ClickerClass.Items;
using ClickerClass;

namespace ClickersOfTheShadows.Content.Items.Weapons.Clicker
{
    public abstract class ClickersOfTheShadowsClicker : ClickerWeapon
    {
        public override string Texture => "ClickersOfTheShadows/Assets/Textures/Content/Items/Weapons/Clicker/" + Name;
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
        public virtual void SafeSetDefaults() { }
        public sealed override void SetDefaults()
        {
            base.SetDefaults();
            SetRadius(Item, RadiusWidth);
            SetColor(Item, RadiusColor);
            SetDust(Item, DustType);
            Effects?.ForEach(effect => AddEffect(Item, effect));
            SafeSetDefaults();
        }
        public virtual void CreateEffects() { }
    }
}