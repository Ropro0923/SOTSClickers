using ClickersOfTheShadows.Core.ModPlayers;
using Terraria;

namespace ClickersOfTheShadows.Common.Utilities
{
    public static class ExtensionMethods
    {
        public static CotSPlayer CotSPlayer(this Player player) => player.GetModPlayer<CotSPlayer>();
    }
}