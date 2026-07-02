using System;
using SOTS.Common.GlobalNPCs;
using Terraria;
using Terraria.ID;

namespace ClickersOfTheShadows.Content.Projectiles
{
    public class AncientSteelClickerProj : CotSClickerProjectile
    {
        public override string Texture => "ClickersOfTheShadows/Assets/Textures/BlankPixel";
        public override void SafeSetDefaults()
        {
            Projectile.width = 15;
            Projectile.height = 15;
            Projectile.aiStyle = -1;
            Projectile.alpha = 255;
            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 10;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            DebuffNPC d = target.GetGlobalNPC<DebuffNPC>();
            if (Main.rand.NextFloat(100) < (float)Math.Pow(0.75f, d.BleedingCurse) * 100 && d.BleedingCurse < 5)
            {
                d.StackDebuff(target, Main.player[Projectile.owner], ref d.BleedingCurse, 1);
            }
        }
        public override void OnKill(int timeLeft)
        {
            for (int i = 0; i < 10; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Silver);
            }
            for (int i = 0; i < 10; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Blood, SpeedX: Main.rand.NextFloat(-6f, 6f), SpeedY: Main.rand.NextFloat(-6f, 6f));
            }
        }
    }
}