using ClickerClass.Projectiles;
using SOTSClickers.Common.Utilities;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SOTSClickers.Core.GlobalProjectiles
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
            if (Main.player[projectile.owner].SOTSClickerPlayer().AccVMedal) projectile.Kill();
        }
    }
}