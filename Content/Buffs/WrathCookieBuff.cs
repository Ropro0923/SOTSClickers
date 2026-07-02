using ClickerClass;
using Terraria;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Content.Buffs
{
    public class WrathCookieBuff : ModBuff
    {
        public override string Texture => $"ClickersOfTheShadows/Assets/Textures/Content/Buffs/{Name}";
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage<ClickerDamage>() += 0.3f;
            ClickerPlayer clickerPlayer = player.GetModPlayer<ClickerPlayer>();
            clickerPlayer.clickerRadius += 0.6f;
            player.lifeRegen += 3;
        }
    }
}
