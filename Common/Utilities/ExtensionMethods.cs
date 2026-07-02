using ClickersOfTheShadows.Core.ModPlayers;
using Terraria;

namespace ClickersOfTheShadows.Common.Utilities
{
    public static class ExtensionMethods
    {
        public static ClickersOfTheShadowsPlayer ClickersOfTheShadowsClickerPlayer(this Player player) => player.GetModPlayer<ClickersOfTheShadowsPlayer>();
    }
}