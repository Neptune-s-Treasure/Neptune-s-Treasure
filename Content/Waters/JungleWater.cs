using System.Collections.Generic;
using Microsoft.Xna.Framework;
using NeptunesTreasure.Common.Interfaces;
using NeptunesTreasure.Utils;
using Terraria;
using Terraria.ModLoader;

namespace NeptunesTreasure.Content.Waters
{
    public class JungleWater() : IWater
    {

        public List<int> GetWaterID()
        {
            return [Water.Jungle];
        }

        public void AI(ModProjectile proj)
        {
            proj.Projectile.tileCollide = true;
            proj.Projectile.velocity.Y = ProjectileExtras.ApplyGravity(proj.Projectile.velocity.Y);
        }

        public void OnHitNPC(ModProjectile proj, NPC target) { }

        public void OnSpawn(ModProjectile proj)
        {
            proj.Projectile.penetrate = 2;
        }

        public void OnTileCollide(ModProjectile proj, Vector2 oldVelocity)
        {
            ProjectileExtras.ApplyBounce(proj, oldVelocity);
        }
    }
}