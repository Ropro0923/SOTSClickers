using ClickerClass.Projectiles;
using ClickersOfTheShadows.Common.Utilities;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Core.GlobalProjectiles
{
    public class VMedalPatch : GlobalProjectile
    {
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
        {
            return entity.type == ModContent.ProjectileType<SMedalPro>() ||
                   entity.type == ModContent.ProjectileType<SMedalPro2>() ||
                   entity.type == ModContent.ProjectileType<SMedalPro3>();
        }
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            if (Main.player[projectile.owner].ClickersOfTheShadowsClickerPlayer().AccVMedal) projectile.Kill();
        }
    }
}