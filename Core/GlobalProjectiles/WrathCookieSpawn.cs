using ClickerClass.Projectiles;
using Microsoft.Xna.Framework;
using SOTSClickers.Common.Utilities;
using SOTSClickers.Content.Projectiles;
using SOTSClickers.Core.ModPlayers;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SOTSClickers.Core.GlobalProjectiles
{
    public class WrathCookie : GlobalProjectile
    {
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation) => entity.type == ModContent.ProjectileType<CookiePro>();
        const int WRATHPERCENT = 75;
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            Player owner = Main.player[projectile.owner];
            SOTSClickerPlayer mp = owner.SOTSClickerPlayer();
            if (projectile.frame != 1 && Main.rand.NextFloat() <= WRATHPERCENT / 100 && mp.AccRaspberryMilkCookies)
            {
                Projectile.NewProjectile(owner.GetSource_Accessory(mp.accRaspberryMilkCookies!), projectile.Center, Vector2.Zero, ModContent.ProjectileType<WrathCookiePro>(), 0, 0, projectile.owner);
                projectile.active = false;
            }
        }
    }
}