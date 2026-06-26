using ClickerClass;
using ClickerClass.Core.Netcode.Packets;
using ClickerClass.Items.Accessories;
using ClickerClass.Projectiles;
using Microsoft.Xna.Framework;
using SOTS.Void;
using SOTSClickers.Content.Buffs;
using SOTSClickers.Content.Items.Accessories;
using SOTSClickers.Content.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace SOTSClickers.Core.ModPlayers
{
    public partial class SOTSClickerPlayer : ModPlayer
    {
        public override void ResetEffects()
        {
            accVMedalItem = null;
            accRaspberryMilkCookies = null;
        }
        public Item? accVMedalItem = null;
        public bool AccVMedal => accVMedalItem != null && !accVMedalItem.IsAir;
        public int accVMedalAmount = 0;

        public Item? accRaspberryMilkCookies = null;
        public bool AccRaspberryMilkCookies => accRaspberryMilkCookies != null && !accRaspberryMilkCookies.IsAir;

        public override void PostUpdateEquips()
        {

            ClickerPlayer clickerPlayer = Player.GetModPlayer<ClickerPlayer>();

            // V Medal
            if (clickerPlayer.clickerSelected && AccVMedal)
            {
                int sMedalType1 = ModContent.ProjectileType<VMedalPro>();
                int sMedalType2 = ModContent.ProjectileType<VMedalPro2>();
                int sMedalType3 = ModContent.ProjectileType<VMedalPro3>();
                int sMedalType4 = ModContent.ProjectileType<VMedalPro4>();

                for (int i = 0; i < Main.maxProjectiles; i++)
                {
                    Projectile proj = Main.projectile[i];

                    if (proj.active && proj.owner == Player.whoAmI && (proj.type == sMedalType1 || proj.type == sMedalType2 || proj.type == sMedalType3 || proj.type == sMedalType4) && proj.ModProjectile is VMedalProBase vMedal)
                    {
                        float len = (proj.Size / 2f).LengthSquared() * 0.78f; //Circle inside the projectile hitbox
                        if (proj.DistanceSQ(Main.MouseWorld) < len)
                        {
                            if (proj.type == sMedalType1 && accVMedalAmount < VMedal.ChargeMeterMax) //V Medal
                            {
                                accVMedalAmount += 4;
                                vMedal.MouseoverAlpha = 1f;
                                Vector2 offset = new(Main.rand.Next(-20, 21), Main.rand.Next(-20, 21));
                                Dust dust = Dust.NewDustDirect(Main.MouseWorld + offset, 8, 8, DustID.GemAmethyst, Scale: 1.25f);
                                dust.noGravity = true;
                                dust.velocity = -offset * 0.05f;
                            }
                            if (proj.type == sMedalType2 && clickerPlayer.accFMedalAmount < FMedal.ChargeMeterMax) //F Medal Equivalent
                            {
                                clickerPlayer.accFMedalAmount += 4;
                                vMedal.MouseoverAlpha = 1f;
                                Vector2 offset = new(Main.rand.Next(-20, 21), Main.rand.Next(-20, 21));
                                Dust dust = Dust.NewDustDirect(Main.MouseWorld + offset, 8, 8, DustID.GemSapphire, Scale: 1.25f);
                                dust.noGravity = true;
                                dust.velocity = -offset * 0.05f;
                            }
                            if (proj.type == sMedalType3 && clickerPlayer.accAMedalAmount < AMedal.ChargeMeterMax) //A Medal Equivalent
                            {
                                clickerPlayer.accAMedalAmount += 4;
                                vMedal.MouseoverAlpha = 1f;
                                Vector2 offset = new(Main.rand.Next(-20, 21), Main.rand.Next(-20, 21));
                                Dust dust = Dust.NewDustDirect(Main.MouseWorld + offset, 8, 8, DustID.GemTopaz, Scale: 1.25f);
                                dust.noGravity = true;
                                dust.velocity = -offset * 0.05f;
                            }
                            if (proj.type == sMedalType4 && clickerPlayer.accSMedalAmount < SMedal.ChargeMeterMax) // S Medal Equivalent
                            {
                                clickerPlayer.accSMedalAmount += 4;
                                vMedal.MouseoverAlpha = 1f;
                                Vector2 offset = new(Main.rand.Next(-20, 21), Main.rand.Next(-20, 21));
                                Dust dust = Dust.NewDustDirect(Main.MouseWorld + offset, 8, 8, DustID.GemEmerald, Scale: 1.25f);
                                dust.noGravity = true;
                                dust.velocity = -offset * 0.05f;
                            }
                        }
                    }
                }
            }
            if (Main.myPlayer == Player.whoAmI)
            {
                if (AccVMedal)
                {
                    int vMedalType1 = ModContent.ProjectileType<VMedalPro>();
                    int vMedalType2 = ModContent.ProjectileType<VMedalPro2>();
                    int vMedalType3 = ModContent.ProjectileType<VMedalPro3>();
                    int vMedalType4 = ModContent.ProjectileType<VMedalPro4>();

                    if (Player.ownedProjectileCounts[vMedalType1] == 0)
                    {
                        Projectile.NewProjectile(Player.GetSource_Accessory(accVMedalItem!), Player.Center, Vector2.Zero, vMedalType1, 0, 0f, Player.whoAmI, 0, 0.5f);
                    }
                    if (Player.ownedProjectileCounts[vMedalType2] == 0)
                    {
                        Projectile.NewProjectile(Player.GetSource_Accessory(accVMedalItem!), Player.Center, Vector2.Zero, vMedalType2, 0, 0f, Player.whoAmI, 1, 0.5f);
                    }
                    if (Player.ownedProjectileCounts[vMedalType3] == 0)
                    {
                        Projectile.NewProjectile(Player.GetSource_Accessory(accVMedalItem!), Player.Center, Vector2.Zero, vMedalType3, 0, 0f, Player.whoAmI, 2, 0.5f);
                    }
                    if (Player.ownedProjectileCounts[vMedalType4] == 0)
                    {
                        Projectile.NewProjectile(Player.GetSource_Accessory(accVMedalItem!), Player.Center, Vector2.Zero, vMedalType4, 0, 0f, Player.whoAmI, 3, 0.5f);
                    }
                }
                else
                {
                    accVMedalAmount = 0;
                }
            }

            // Raspberry Milk n' Cookies
            if (Player.whoAmI == Main.myPlayer)
            {
                int cookieType = ModContent.ProjectileType<WrathCookiePro>();
                for (int i = 0; i < Main.maxProjectiles; i++)
                {
                    Projectile proj = Main.projectile[i];

                    if (proj.active && proj.owner == Player.whoAmI && proj.type == cookieType && proj.ModProjectile is WrathCookiePro)
                    {
                        if (Main.mouseLeft && Main.mouseLeftRelease && proj.DistanceSQ(Main.MouseWorld) < 30 * 30)
                        {
                            SoundEngine.PlaySound(SoundID.Item2, Player.Center);
                            Player.AddBuff(ModContent.BuffType<WrathCookieBuff>(), 300);
                            for (int k = 0; k < 10; k++)
                            {
                                Dust dust = Dust.NewDustDirect(proj.Center, 20, 20, DustID.CrimsonPlants, Main.rand.NextFloat(-4f, 4f), Main.rand.NextFloat(-4f, 4f), 75, default, 1.5f);
                                dust.noGravity = true;
                            }
                            clickerPlayer.paintingCondition_ClickedCookiesCount++;
                            if (clickerPlayer.paintingCondition_ClickedCookiesCount == 100)
                            {
                                clickerPlayer.paintingCondition_Clicked100Cookies = true;
                                if (Main.netMode == NetmodeID.MultiplayerClient)
                                {
                                    new Clicked100CookiesPacket(Player).Send();
                                }
                            }
                            proj.Kill();
                        }
                    }
                }
            }
        }
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (ClickerSystem.IsClickerWeaponProj(proj))
            {
                int vMedalStep = VMedal.ChargeMeterStep;
                if (accVMedalAmount >= vMedalStep)
                {
                    VoidPlayer.ModPlayer(Player).voidMeter += VMedal.VoidRecovery;
                    accVMedalAmount -= vMedalStep;
                }
            }
        }
    }
}