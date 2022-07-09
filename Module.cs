using Monocle;

namespace Celeste.Mod.DoNotKnow
{
    public class DoNotKnow : EverestModule
    {
        public static DoNotKnow Instance;

        public DoNotKnow()
        {
            Instance = this;
        }

        public SpriteBank DNKSpriteBank;

        public override void Load()
        {
            Logger.SetLogLevel("DoNotKnow", LogLevel.Verbose);
            Logger.Log(LogLevel.Info, "DoNotKnow", "Load");
        }

        public override void LoadContent(bool firstLoad)
        {
            Logger.Log(LogLevel.Info, "DoNotKnow", "Load Content");
            DNKSpriteBank = new SpriteBank(GFX.Game, "Graphics/DoNotKnowSpriteBank.xml");
            //GFX.SpriteBank.Create("Graphics/DoNotKnowSpriteBank.xml"); // added from entity to see if failed level load can be avoided. actually causes launch failure
        }

        public override void Unload()
        {
            Logger.Log(LogLevel.Info, "DoNotKnow", "Unload");
        }
    }
}
