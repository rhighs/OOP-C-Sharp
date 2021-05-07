using System;

namespace Montalti
{
    class Ambient : IAmbient
    {

        public Node RootNode { get; internal set; }

        public ViewPort ViewPort { get; internal set; }

        public AssetManager AssetManager { get; internal set; }

        public Vector3f CamLightDirection { get; set; }

        public ColorRGBA BackGroundColor { get; set; }

        public Ambient(AssetManager assetManager, Node rootNode, ViewPort viewPort)
        {
            RootNode = rootNode;
            ViewPort = ViewPort;
            AssetManager = assetManager;
        }

        public void AddSunLight(Vector3f direction)
        {
            //jmonkey engnie light setting... 
        }

        public void AddShadowFilter(Vector3f lightSourceDirection)
        {
            //jmonkey shadows setting...
        }

    }
}
