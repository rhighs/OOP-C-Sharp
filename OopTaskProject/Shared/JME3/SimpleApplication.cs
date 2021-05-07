using System;
using Items;

namespace Montalti
{
    class SimpleApplication : ISimpleApplication
    {

        private Node guiNode;

        private Camera camera;

        private FlyByCamera flyByCamera;

        private AssetManager assetManager;

        private InputManger inputManager;

        private StateManager stateManager;

        private ViewPort viewPort;

        public SimpleApplication()
        {
            //snip
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

    }

}
