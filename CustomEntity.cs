using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;
using System;

namespace Celeste.Mod.DoNotKnow
{
    [CustomEntity("DoNotKnow/CustomEntity")]
    public class CustomEntity : Entity
    {

        private Sprite sprite;
        private SpriteBank bank;

        private PlayerCollider pc;

        private float respawnTimer;

        public CustomEntity(EntityData data, Vector2 offset) : base(data.Position + offset)
        {
            Logger.Log(LogLevel.Info, "DoNotKnow", "Added instance of CustomEntity");
            Logger.Log(LogLevel.Debug, "DoNotKnow", base.Center.ToString());
            bank = new SpriteBank(GFX.Game, "Graphics/DoNotKnowSpriteBank.xml");
            this.sprite = bank.Create("CustomEntity");

            base.Add(this.sprite);
            this.sprite.Play("idle");

            base.Collider = new Hitbox(64f, 64f, -32f, -32f);
            base.Add(this.pc = new PlayerCollider(new Action<Player> (this.OnCollide), null, null));


            base.Depth = -10000;
        }

        private void OnCollide(Player player)
        {
            this.Collidable = false;
            this.respawnTimer = 3f;
            player.ExplodeLaunch(new Vector2(0f,0f), false);
            return;
        }

        private void Respawn()
        {
            this.Collidable = true;
        }

        public override void Added(Scene scene)
        {
            base.Added(scene);
        }

        public override void Awake(Scene scene)
        {
            base.Awake(scene);
            // can check for other entities present in level but i dont want to so i wont
        }

        public override void Update()
        {
            base.Update();
            if(this.respawnTimer > 0f)
            {
                this.respawnTimer -= Engine.DeltaTime;
                if(this.respawnTimer <= 0f)
                {
                    this.Respawn();
                }
            }
        }

        public override void Render()
        {
            base.Render();
        }

        public override void Removed(Scene scene)
        {
            base.Removed(scene);
        }
    }
}