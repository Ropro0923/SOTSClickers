using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using ClickerClass;
using SOTSClickers.Core;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using SOTSClickers.Content.Projectiles;

namespace SOTSClickers.Content.Items.Weapons.Clicker
{
    public class AncientSteelClicker : SOTSClicker
    {
        public override float RadiusWidth => 1.7f;
        public override Color RadiusColor => new(108, 115, 140);
        public override int DustType => DustID.Silver;

        public override List<string>? Effects => ["SOTSClickers:AncientSteelEffect"];

        public override void SafeSetDefaults()
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
            SOTSClickEffects.AncientSteelEffect = ClickerSystem.RegisterClickEffect(Mod, "AncientSteelEffect", 11, RadiusColor, delegate (Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, int type, int damage, float knockBack)
            {
                Projectile.NewProjectile(source, position, Vector2.Zero, ModContent.ProjectileType<AncientSteelClickerProj>(), damage, knockBack, player.whoAmI);
            },
            preHardMode: true);
        }
    }
}