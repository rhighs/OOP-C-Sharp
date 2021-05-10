using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Shared.JME3
{
    public class SimpleApplication : ISimpleApplication
    {
        private Node guiNode;

        private Camera camera;

        private FlyByCamera flyByCamera;

        private AssetManager assetManager;

        private InputManager inputManager;

        private StateManager stateManager;

        private ViewPort viewPort;

        private Node rootNode;

        public SimpleApplication()
        {
            guiNode = new Node();
            camera = new Camera();
            flyByCamera = new FlyByCamera();
            assetManager = new AssetManager();
            viewPort = new ViewPort();
            stateManager = new StateManager();
            rootNode = new Node();
            inputManager = new InputManager();
        }

        public Node GetGuiNode()
        {
            return guiNode;
        } 

        public Camera GetCamera()
        {
            return camera;
        }

        public FlyByCamera GetFlyByCamera()
        {
            return flyByCamera;
        }

        public AssetManager GetAssetManager()
        {
            return assetManager;
        }

        public ViewPort GetViewPort()
        {
            return viewPort;
        }

        public StateManager GetStateManager()
        {
            return stateManager;
        }

        public Node GetRootNode()
        {
            return rootNode;
        }

        public InputManager GetInputManager()
        {
            return inputManager;
        }
    }

}
