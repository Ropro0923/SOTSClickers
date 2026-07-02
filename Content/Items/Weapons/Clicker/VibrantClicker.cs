using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using ClickerClass;
using ClickersOfTheShadows.Core;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using SOTS.Dusts;
using SOTS.Projectiles.Laser;

namespace ClickersOfTheShadows.Content.Items.Weapons.Clicker
{
    public class VibrantClicker : ClickersOfTheShadowsClicker
    {
        public override float RadiusWidth => 1f;
        public override Color RadiusColor => new(117, 156, 35);
        public override int DustType => ModContent.DustType<VibrantDust>();
        public override List<string>? Effects => ["ClickersOfTheShadows:VibrantEffect"];
        public override void SafeSetDefaults()
        {
            Item.damage = 1;
            Item.width = 16;
            Item.height = 12;
            Item.rare = ItemRarityID.Blue;
        }
        public override void CreateEffects()
        {
            ClickersOfTheShadowsClickEffects.VibrantEffect = ClickerSystem.RegisterClickEffect(Mod, "VibrantEffect", 11, RadiusColor, delegate (Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, int type, int damage, float knockBack)
            {
                Projectile.NewProjectile(source, position, Vector2.Zero, ModContent.ProjectileType<VibrantRing>(), damage, 0);
            },
            preHardMode: true);
        }
    }
}