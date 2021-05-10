using OopTaskProject.Chris;
using OopTaskProject.Shared.JME3;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Rob {

    public class Locator {
        public ISimpleApplication _app;

        public IAmbient AmbientService { get; private set; }

        public IPhysics PhysicsService { get; private set; }

        public IInputHandler InputService { get; private set; }

        public IGraphics GraphicsService { get; private set; }

        public IMainMap MapService { get; private set; }

        public ISimulationCamera CamService { get; private set; }

        public Node GuiNode { get; private set; }

        public Locator(ISimpleApplication app){
            _app = app;
            GuiNode = _app.GetGuiNode();
            
            var rootNode = _app.GetRootNode();
            var assetManager = _app.GetAssetManager();
            var bullet = new BulletAppState();
            _app.GetStateManager().Attach(bullet);

            GraphicsService = new Graphics(assetManager, rootNode);
            PhysicsService = new Physics(bullet);
            AmbientService = new Ambient(assetManager, rootNode, app.GetViewPort());
            MapService = new MainMap();
            InputService = new InputHandler(_app.GetInputManager());
            CamService = new SimulationCamera(_app.GetCamera(), _app.GetFlyByCamera());
        }
    }
}
