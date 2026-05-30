// using ClickerClass.Prefixes.ClickerPrefixes;
// using SOTS;
// using SOTSClickers.Content.Items.Weapons.VoidClicker;
// using Terraria;
// using Terraria.ModLoader;
// 
// namespace SOTSClickers.Content.Prefixes
// {
//     public class Famished : ClickerPrefix
//     {
//         public override float RollChance(Item item) => 1f;
//         public override bool CanRoll(Item item) => item.ModItem is SOTSVoidClicker;
//         public override PrefixCategory Category => PrefixCategory.Custom;
//         public override void Apply(Item item)
//         {
//             item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 1.25f;
//         }
//         public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
//         {
//             damageMult -= 0.10f;
//             knockbackMult -= 0.10f;
//             base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
//         }
//         public override void ModifyValue(ref float valueMult)
//         {
//             float multiplier = 0.9f;
//             valueMult *= multiplier;
//         }
//     }
//     public class Precarious : ClickerPrefix
//     {
//         public override float RollChance(Item item) => 1f;
//         public override bool CanRoll(Item item) => item.ModItem is SOTSVoidClicker;
//         public override PrefixCategory Category => PrefixCategory.Custom;
//         public override void Apply(Item item)
//         {
//             item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 1.2f;
//         }
//         public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
//         {
//             damageMult += 0.10f;
//             useTimeMult -= 0.05f;
//             knockbackMult += 0.10f;
//             base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
//         }
//         public override void ModifyValue(ref float valueMult)
//         {
//             float multiplier = 1.03f;
//             valueMult *= multiplier;
//         }
//     }
//     public class Potent : ClickerPrefix
//     {
//         public override float RollChance(Item item) => 0.75f;
//         public override bool CanRoll(Item item) => item.ModItem is SOTSVoidClicker;
//         public override PrefixCategory Category => PrefixCategory.Custom;
//         public override void Apply(Item item)
//         {
//             item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 0.9f;
//         }
//         public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
//         {
//             damageMult += 0.05f;
//             useTimeMult -= 0.05f;
//             base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
//         }
//         public override void ModifyValue(ref float valueMult)
//         {
//             float multiplier = 1.07f;
//             valueMult *= multiplier;
//         }
//     }
//     public class Omnipotent : ClickerPrefix
//     {
//         public override float RollChance(Item item) => 0.7f;
//         public override bool CanRoll(Item item) => item.ModItem is SOTSVoidClicker;
//         public override PrefixCategory Category => PrefixCategory.Custom;
//         public override void Apply(Item item)
//         {
//             item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 0.9f;
//         }
//         public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
//         {
//             damageMult += 0.15f;
//             useTimeMult -= 0.10f;
//             knockbackMult += 0.15f;
//             critBonus += 5;
//             base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
//         }
//         public override void ModifyValue(ref float valueMult)
//         {
//             float multiplier = 1.16f;
//             valueMult *= multiplier;
//         }
//     }
//     public class Chthonic : ClickerPrefix
//     {
//         public override float RollChance(Item item) => 0.8f;
//         public override bool CanRoll(Item item) => item.ModItem is SOTSVoidClicker;
//         public override PrefixCategory Category => PrefixCategory.Custom;
//         public override void Apply(Item item)
//         {
//             item.GetGlobalItem<PrefixItem>().voidCostMultiplier = 1.1f;
//         }
//         public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
//         {
//             damageMult += 0.24f;
//             useTimeMult += 0.06f; //this is bad
//             knockbackMult -= 0.06f;
//             base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
//         }
//         public override void ModifyValue(ref float valueMult)
//         {
//             float multiplier = 1.06f;
//             valueMult *= multiplier;
//         }
//     }
// }