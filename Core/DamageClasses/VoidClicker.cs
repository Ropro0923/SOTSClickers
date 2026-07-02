using ClickerClass;
using SOTS.Void;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Core.DamageClasses
{
    public class VoidClicker : DamageClass
    {
        public static VoidClicker Instance => ModContent.GetInstance<VoidClicker>();
        public override bool UseStandardCritCalcs => true;
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            return damageClass == Generic || damageClass == ModContent.GetInstance<VoidGeneric>() || damageClass == ModContent.GetInstance<ClickerDamage>() ? StatInheritanceData.Full : StatInheritanceData.None;
        }
        public override bool GetEffectInheritance(DamageClass damageClass)
        {
            if (damageClass != ModContent.GetInstance<ClickerDamage>())
            {
                return damageClass == ModContent.GetInstance<VoidGeneric>();
            }
            return true;
        }
    }
}