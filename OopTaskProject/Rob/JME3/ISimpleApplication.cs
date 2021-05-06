using System;


namespace Montalti
{
    interface ISimpleApplication
    {
        public Node GetGuiNode();

        public StateManager GetStateManager(); 

        public Node GetRootNode();

        public AssetManager GetAssetManager();

        public InputManager GetInputManger();

        public FlyByCamera GetFlyByCamera();

        public Camera GetCamera();

        public ViewPort GetViewPort();
    }
}
