using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public class Graphics : IGraphics
    {
        private AssetManager _assetManager;

        private Node _rootNode;

        public Spatial Model { get; internal set; }

        private readonly string MODEL_PATH = "./model.txt";

        private readonly string DIFFUSE_COLOR_KEY = "Diffuse";

        private readonly string AMBIENT_COLOR_KEY = "Ambient";

        public Graphics(AssetManager assetManager, Node rootNode)
        {
            _assetManager = assetManager;
            _rootNode = rootNode;

            Model = _assetManager.LoadModel(MODEL_PATH);
        }

        public void AddToScene(Spatial elem)
        {
            _rootNode.AttachChild(elem);
        }

        public Material CreateShadedMaterial(ColorRGBA ambient, ColorRGBA diffuse)
        {
            var m = new Material();

            m.SetColor(AMBIENT_COLOR_KEY, ambient);
            m.SetColor(DIFFUSE_COLOR_KEY, diffuse);

            return m;
        }

        public void ChangeMaterialColor(Spatial spatial, ColorRGBA color){
            spatial.GetMaterial().SetColor(DIFFUSE_COLOR_KEY, color);
        }
    }
}
