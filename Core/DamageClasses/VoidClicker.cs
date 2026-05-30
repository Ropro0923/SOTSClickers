using ClickerClass;
using SOTS.Void;
using Terraria.ModLoader;

namespace SOTSClickers.Core.DamageClasses
{
    public class VoidClicker : DamageClass
    {
        public static VoidClicker Instance => ModContent.GetInstance<VoidClicker>();
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            return damageClass == Generic || damageClass == ModContent.GetInstance<VoidGeneric>() || damageClass == ModContent.GetInstance<ClickerDamage>() ? StatInheritanceData.Full : new StatInheritanceData(0.0f, 0.0f, 0.0f, 0.0f, 0.0f);
        }
        public override bool GetEffectInheritance(DamageClass damageClass)
        {
            return damageClass == ModContent.GetInstance<ClickerDamage>() || damageClass != ModContent.GetInstance<VoidGeneric>();
        }
        public override bool GetPrefixInheritance(DamageClass damageClass)
        {
            return damageClass == ModContent.GetInstance<ClickerDamage>();
        }
    }
}