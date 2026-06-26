using SOTSClickers.Core.ModPlayers;
using Terraria;

namespace SOTSClickers.Common.Utilities
{
    public static class ExtensionMethods
    {
        public static SOTSClickerPlayer SOTSClickerPlayer(this Player player) => player.GetModPlayer<SOTSClickerPlayer>();
    }
}