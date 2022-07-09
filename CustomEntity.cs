using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;

namespace Celeste.Mod.DoNotKnow
{
    [CustomEntity("DoNotKnow/CustomEntity")]
    public class CustomEntity : Entity
    {

        private Sprite sprite;
        private SpriteBank bank;

        public CustomEntity(EntityData data, Vector2 offset) : base(data.Position + offset) // NOT WORKING
        {
            Logger.Log(LogLevel.Info, "DoNotKnow", "Added instance of CustomEntity"); // this will probably never output. but it has
            bank = new SpriteBank(GFX.Game, "Graphics/DoNotKnowSpriteBank.xml"); // added because I thought it might help somehow. it doesn't 
            //this.sprite = GFX.SpriteBank.Create(); // and this prevents the level from loading, also gives useless error message about missing animimations
            //this.sprite.AddLoop("idle", "", 0.1f); // not needed if using a sprite bank

            // however the atlases are made and custom sprites are done, is poorly documented and
            // scattered across several different pages of docs with conflicting information so
            // ive redone everything several times and at this point ive gone insane.
            // i shouldn't have to ask for help on discord for something seemingly
            // so basic.

            base.Add(this.sprite);
            //this.sprite.Play("idle"); // not sure if i need
            base.Depth = -10000;
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