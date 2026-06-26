using ClickerClass;
using ClickerClass.Buffs;
using Terraria;

namespace SOTSClickers.Content.Buffs
{
    public class WrathCookieBuff : CookieBuff
    {
        public override string Texture => $"SOTSClickers/Assets/Textures/Content/Buffs/{Name}";
        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetDamage<ClickerDamage>() *= 1.15f;
        }
    }
}
