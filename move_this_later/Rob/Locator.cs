using System;


namespace Montalti {

    public class Locator : ILocator {

        public IPhysics Physics { get; internal set; }

        public IInputHandler Input { get; internal set; }

        public IGraphics Graphics { get; internal set; }

        public ISimpleApplication App { get; internal set; }

        public IMainMap Map { get; internal set; }

        public ISimulationCamera Cam { get; internal set; }

        public Node GuiNode { get; internal set; }

        public Locator(ISimpleApplication app){
            App = app;
            GuiNode = App.GetGuiNode();
            
            var rootNode = App.GetRootNode();
            var assetManager = App.GetAssetManager();
            var bullet = new BulletAppState();
            App.GetStateManager().Attach(bullet);

            Graphics = new Graphics(assetManager, rootNode);
            Physics = new Physics(bullet);
            Ambient = new Ambient(assetManager, rootNode, app.GetViewPort());
            Map = new MainMap(assetManager, bullet, rootNode);
            Input = new InputHandler(app.GetInputManager());
            Cam = new SimulationCamera(App.GetCamera(), App.GetFlyByCamera());
        }

    }
}
