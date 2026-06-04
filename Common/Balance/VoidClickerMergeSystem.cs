//using System;
//using System.Reflection;
//using MonoMod.RuntimeDetour;
//using SOTS;
//using SOTS.Void;
//using SOTSClickers.Content.Items.Weapons.VoidClicker;
//using SOTSClickers.Content.Prefixes;
//using Terraria;
//using Terraria.ModLoader;
//
//namespace SOTSClickers.Common.Balance
//{
//    public class VoidClickerMergeSystem : ModSystem
//    {
//        static Hook? voidCostHook;
//        public override void Load()
//        {
//            MethodInfo? method = typeof(VoidItem).GetMethod("VoidCost", BindingFlags.Public | BindingFlags.Instance);
//            if (method != null)
//                voidCostHook = new Hook(method, VoidCostDetour);
//        }
//        private int VoidCostDetour(Func<VoidItem, Player, int> orig, VoidItem self, Player player)
//        {
//            Item item = self.Item;
//            if (self is SOTSVoidClicker && (item.prefix == ModContent.PrefixType<FamishedClicker>() || item.prefix == ModContent.PrefixType<PrecariousClicker>() || item.prefix == ModContent.PrefixType<PotentClicker>() || item.prefix == ModContent.PrefixType<OmnipotentClicker>() || item.prefix == ModContent.PrefixType<ChthonicClicker>()))
//            {
//                return (int)(self.GetVoid(player) * VoidPlayer.ModPlayer(player).voidCost * item.GetGlobalItem<PrefixItem>().voidCostMultiplier);
//            }
//            else
//            {
//                return orig(self, player);
//            }
//        }
//        public override void Unload()
//        {
//            voidCostHook?.Dispose();
//            voidCostHook = null;
//        }
//    }
//}