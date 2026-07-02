using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using ClickerClass;
using ClickersOfTheShadows.Core;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using ClickersOfTheShadows.Content.Projectiles;

namespace ClickersOfTheShadows.Content.Items.Weapons.Clicker
{
    public class AncientSteelClicker : ClickersOfTheShadowsClicker
    {
        public override float RadiusWidth => 1f;
        public override Color RadiusColor => new(108, 115, 140);
        public override int DustType => DustID.Silver;
        public override List<string>? Effects => ["ClickersOfTheShadows:AncientSteelEffect"];
        public override void SafeSetDefaults()
        {
            Item.damage = 1;
            Item.width = 16;
            Item.height = 22;
            Item.rare = ItemRarityID.Blue;
        }
        public override void CreateEffects()
        {
            ClickersOfTheShadowsClickEffects.AncientSteelEffect = ClickerSystem.RegisterClickEffect(Mod, "AncientSteelEffect", 11, RadiusColor, delegate (Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, int type, int damage, float knockBack)
            {
                Projectile.NewProjectile(source, position, Vector2.Zero, ModContent.ProjectileType<AncientSteelClickerProj>(), damage, knockBack, player.whoAmI);
            },
            preHardMode: true);
        }
    }
}