using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public class Ambient : IAmbient
    {

        public Node RootNode { get; internal set; }

        public ViewPort ViewPort { get; internal set; }

        public AssetManager AssetManager { get; internal set; }

        public Vector3F CamLightDirection { get; set; }

        public ColorRGBA BackGroundColor { get; set; }

        public Ambient(AssetManager assetManager, Node rootNode, ViewPort viewPort)
        {
            RootNode = rootNode;
            ViewPort = ViewPort;
            AssetManager = assetManager;
        }

        public void AddSunLight(Vector3F direction)
        {
            //jmonkey engnie light setting... 
        }

        public void AddShadowFilter(Vector3F lightSourceDirection)
        {
            //jmonkey shadows setting...
        }

    }
}
