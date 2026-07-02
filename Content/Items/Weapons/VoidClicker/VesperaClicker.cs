using System.Collections.Generic;
using ClickerClass;
using Microsoft.Xna.Framework;
using SOTS.Dusts;
using SOTS.Projectiles.Earth;
using ClickersOfTheShadows.Core;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Content.Items.Weapons.VoidClicker
{

    public class VesperaClicker : ClickersOfTheShadowsVoidClicker
    {
        public override float RadiusWidth => 1f;
        public override Color RadiusColor => new(79, 98, 113);
        public override int DustType => ModContent.DustType<CopyDust4>();
        public override List<string>? Effects => ["ClickersOfTheShadows:VesperaEffect"];
        public override int GetVoid(Player player) => 10;
        public override void VoidSetDefaults()
        {
            Item.damage = 1;
            Item.width = 16;
            Item.height = 22;
            Item.rare = ItemRarityID.Blue;
        }
        public const int ROCK_COUNT = 3;
        public override void CreateEffects()
        {
            ClickersOfTheShadowsClickEffects.VesperaEffect = ClickerSystem.RegisterClickEffect(Mod, "VesperaEffect", 7, RadiusColor, delegate (Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, int type, int damage, float knockBack)
            {
                for (int i = 0; i < ROCK_COUNT; i++)
                {
                    Projectile.NewProjectile(source, position, new Vector2((i - 1) * 1.35f + Main.rand.NextFloat(-0.45f, 0.45f), -Main.rand.NextFloat(2, 3)), ModContent.ProjectileType<EvostonePebble>(), damage, knockBack, player.whoAmI);
                }
            },
            preHardMode: true,
            descriptionArgs: [ROCK_COUNT]);
        }
    }
}