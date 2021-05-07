using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Shared.JME3
{
    public interface ISimpleApplication
    {
        public Node GetGuiNode();

        public StateManager GetStateManager(); 

        public Node GetRootNode();

        public AssetManager GetAssetManager();

        public FlyByCamera GetFlyByCamera();

        public Camera GetCamera();

        public ViewPort GetViewPort();
        public InputManager GetInputManager();
    }
}
