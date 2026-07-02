using ClickerClass.Projectiles;

namespace ClickersOfTheShadows.Content.Projectiles
{
    public abstract class CotSClickerProjectile : ClickerProjectile
    {
        public virtual void SafeSetStaticDefaults() { }
        public sealed override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            SafeSetStaticDefaults();
        }
        public virtual void SafeSetDefaults() { }
        public sealed override void SetDefaults()
        {
            base.SetDefaults();
            SafeSetDefaults();
        }
    }
}