using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SOTSClickers
{
    public class SOTSClickers : Mod
    {
        public static SOTSClickers? Instance;
        public override void Load()
        {
            Instance = this;
        }
        public override void Unload()
        {
            Instance = null;
        }
        public static readonly Mod Clicker = ModLoader.GetMod("ClickerClass"), Sots = ModLoader.GetMod("SOTS");
    }
    public class DebugItem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine Value = new(Mod, "Value", "Value: " + item.value.ToString())
            {
                OverrideColor = Color.Green
            };
            tooltips.Add(Value);
            TooltipLine Rare = new(Mod, "Rarity", "Rarity: " + item.rare.ToString())
            {
                OverrideColor = Color.Cyan
            };
            tooltips.Add(Rare);
            TooltipLine Name = new(Mod, "Name", "Name: " + ItemID.Search.GetName(item.type))
            {
                OverrideColor = Color.Red
            };
            tooltips.Add(Name);
        }
    }
}
