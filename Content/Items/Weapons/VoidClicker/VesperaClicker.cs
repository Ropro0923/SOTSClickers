using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using ClickerClass;
using SOTSClickers.Core;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using SOTS.Dusts;

namespace SOTSClickers.Content.Items.Weapons.VoidClicker
{
    public class VesperaClicker : SOTSVoidClicker
    {
        public override float RadiusWidth => 1.7f;
        public override Color RadiusColor => new(79, 98, 113);
        public override int DustType => ModContent.DustType<CopyDust4>();

        public override List<string>? Effects => ["SOTSClickers:VesperaEffect"];

        public override int GetVoid(Player player) => 5;

        public override void VoidSafeSetDefaults()
        {
            Item.damage = 5;
            Item.width = 30;
            Item.height = 30;
            Item.knockBack = 0.5f;
            //    Item.value = Item.sellPrice(0, 0, 18, 0);
            Item.rare = ItemRarityID.Blue;
        }
        public override void CreateEffects()
        {
            SOTSClickEffects.VesperaEffect = ClickerSystem.RegisterClickEffect(Mod, "VesperaEffect", 11, RadiusColor, delegate (Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, int type, int damage, float knockBack)
            {

            },
            preHardMode: true);
        }
    }
}