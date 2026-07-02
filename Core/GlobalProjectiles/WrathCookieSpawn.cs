using ClickerClass.Projectiles;
using Microsoft.Xna.Framework;
using ClickersOfTheShadows.Common.Utilities;
using ClickersOfTheShadows.Content.Projectiles;
using ClickersOfTheShadows.Core.ModPlayers;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Core.GlobalProjectiles
{
    public class WrathCookie : GlobalProjectile
    {
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation) => entity.type == ModContent.ProjectileType<CookiePro>();
        const float WRATHPERCENT = 75;
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            Player owner = Main.player[projectile.owner];
            CotSPlayer mp = owner.CotSPlayer();
            if (projectile.frame != 1 && Main.rand.NextFloat() <= WRATHPERCENT / 100 && mp.AccWrathCookie)
            {
                Projectile.NewProjectile(owner.GetSource_Accessory(mp.accWrathCookie!), projectile.Center, Vector2.Zero, ModContent.ProjectileType<WrathCookiePro>(), 0, 0, projectile.owner);
                projectile.active = false;
            }
        }
    }
}