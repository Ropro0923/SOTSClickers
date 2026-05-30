using ClickerClass.Projectiles;

namespace SOTSClickers.Content.Projectiles
{
    public abstract class SOTSClickerProjectile : ClickerProjectile
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