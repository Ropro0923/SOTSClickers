
using Terraria;
using Terraria.ModLoader;
using SOTSClickers.Content.Items.Weapons.VoidClicker;
using Terraria.Localization;
using SOTS.Void;
using ClickerClass.Prefixes.ClickerPrefixes;
using System.Reflection;
using System.Collections.Generic;
    
namespace SOTSClickers.Core.DamageClasses
{
    public class VoidClickerFix : GlobalItem
    {
        public override void Load()
        {
            if (typeof(ClickerPrefix).GetField("ClickerPrefixes", BindingFlags.NonPublic | BindingFlags.Static)?.GetValue(null) is List<int> clickerPrefixes)
            {
                clickerPrefixes.Add(ModContent.PrefixType<Famished>());
                clickerPrefixes.Add(ModContent.PrefixType<Precarious>());
                clickerPrefixes.Add(ModContent.PrefixType<Potent>());
                clickerPrefixes.Add(ModContent.PrefixType<Omnipotent>());
                clickerPrefixes.Add(ModContent.PrefixType<Chthonic>());
            }
        }
        public override bool AppliesToEntity(Item item, bool lateInstantiation) => item.ModItem is SOTSVoidClicker;
        public override void SetDefaults(Item item)
        {
            item.DamageType = ModContent.GetInstance<VoidClicker>();
        }

        public override void ModifyTooltips(Item item, System.Collections.Generic.List<TooltipLine> tooltips)
        {
            tooltips[tooltips.FindIndex(t => t.Name == "Damage" && t.Mod == "Terraria")].Text = Language.GetTextValue("Mods.SOTSClickers.DamageClasses.VoidClicker.DisplayName", item.damage, Language.GetTextValue("Mods.SOTS.Common.Damage"));

            if (item.prefix == ModContent.PrefixType<Pro>())
            {
                int voidCostTooltip = 10;

                string sign = voidCostTooltip > 0 ? "+" : "";
                TooltipLine line = new(Mod, "PrefixAwakened", sign + voidCostTooltip + Language.GetTextValue("Mods.SOTS.Prefixes.CosVoid.DisplayName"))
                {
                    OverrideColor = new(190, 120, 120)
                };
                tooltips.Insert(tooltips.FindIndex(t => t.Name == "PrefixClickerRadius" && t.Mod == SOTSClickers.Clicker.Name) + 1, line);
            }
        }
    }
}