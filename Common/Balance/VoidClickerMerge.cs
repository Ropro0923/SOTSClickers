using Terraria;
using Terraria.ModLoader;
using ClickersOfTheShadows.Content.Items.Weapons.VoidClicker;
using System.Collections.Generic;
using System.Linq;
using Terraria.Localization;
using ClickersOfTheShadows.Core.DamageClasses;
using SOTS.Void;
using ClickersOfTheShadows.Content.Prefixes;
using System;
using System.Reflection;
using MonoMod.RuntimeDetour;
using SOTS;

namespace ClickersOfTheShadows.Common.Balance
{
    public class VoidClickerMerge : GlobalItem
    {
        public override bool AppliesToEntity(Item item, bool lateInstantiation) => item.ModItem is ClickersOfTheShadowsVoidClicker;
        public override void SetDefaults(Item item)
        {
            item.DamageType = VoidClicker.Instance;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine? damage = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.Mod == "Terraria");
            if (damage != null)
            {
                string[] splitText = damage.Text.Split(' ');
                string damageValue = splitText.First();
                //    string damageWord = Language.GetTextValue("Mods.SOTS.Common.Damage");

                if (item.CountsAsClass(ModContent.GetInstance<VoidClicker>()))
                    damage.Text = Language.GetTextValue("Mods.ClickersOfTheShadows.DamageClasses.VoidClicker.DisplayName", damageValue);
            }

            TooltipLine? consumevoid = tooltips.FirstOrDefault(x => x.Name == "UseMana" && x.Mod == "Terraria");
            TooltipLine? clickeffect = tooltips.FirstOrDefault(x => x.Name.Contains("ClickEffect_") && x.Mod == ClickersOfTheShadows.Clicker.Name);
            if (consumevoid != null && clickeffect != null)
            {
                TooltipLine line = consumevoid;
                tooltips.Remove(consumevoid);
                tooltips.Insert(tooltips.IndexOf(clickeffect), line);
            }

            if (item.prefix != -1)
            {
                TooltipLine? tt = tooltips.LastOrDefault(x => x.IsModifier);
                if (tt != null)
                {
                    if (item.prefix == ModContent.PrefixType<FamishedClicker>())
                        InsertVoid(1.1f);
                    else if (item.prefix == ModContent.PrefixType<PrecariousClicker>())
                        InsertVoid(1.2f);
                    else if (item.prefix == ModContent.PrefixType<PotentClicker>())
                        InsertVoid(0.9f);
                    else if (item.prefix == ModContent.PrefixType<OmnipotentClicker>())
                        InsertVoid(0.9f);
                    else if (item.prefix == ModContent.PrefixType<ChthonicClicker>())
                        InsertVoid(1.1f);
                }
            }
            void InsertVoid(float mult)
            {
                TooltipLine? tt = tooltips.LastOrDefault(x => x.IsModifier);
                int voidCostTooltip = (int)(100f * (mult - 1f));
                TooltipLine line = new(Mod, "PrefixAwakened", Language.GetText("Mods.SOTS.Prefixes.Effects.CosVoid").WithFormatArgs(voidCostTooltip).Value)
                {
                    IsModifier = true,
                    IsModifierBad = mult > 1f,
                };
                tooltips.Insert(tooltips.IndexOf(tt!) + 1, line);
            }
        }
        static Hook? voidCostHook;
        public override void Load()
        {
            MethodInfo? method = typeof(VoidItem).GetMethod("VoidCost", BindingFlags.Public | BindingFlags.Instance);
            if (method != null)
                voidCostHook = new Hook(method, VoidCostDetour);
        }
        private int VoidCostDetour(Func<VoidItem, Player, int> orig, VoidItem self, Player player)
        {
            Item item = self.Item;
            if (self is ClickersOfTheShadowsVoidClicker && (item.prefix == ModContent.PrefixType<FamishedClicker>() || item.prefix == ModContent.PrefixType<PrecariousClicker>() || item.prefix == ModContent.PrefixType<PotentClicker>() || item.prefix == ModContent.PrefixType<OmnipotentClicker>() || item.prefix == ModContent.PrefixType<ChthonicClicker>()))
            {
                return (int)(self.GetVoid(player) * VoidPlayer.ModPlayer(player).voidCost * item.GetGlobalItem<PrefixItem>().voidCostMultiplier);
            }
            else
            {
                return orig(self, player);
            }
        }
        public override void Unload()
        {
            voidCostHook?.Dispose();
            voidCostHook = null;
        }
    }
}