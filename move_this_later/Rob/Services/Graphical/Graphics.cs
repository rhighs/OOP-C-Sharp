using System;

namespace Montalti
{
    class Graphics : IGraphics
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
            rootNode.AttachChild(elem);
        }

        public Material crateShadedMaterial(ColorRGBA ambient, ColorRGBA diffuse)
        {
            var material = new Material(_assetManager);
            material.SetColor(AMBIENT_COLOR_KEY, ambient);
            material.SetColor(DIFFUSE_COLOR_KEY, diffuse);

            return material;
        }

        public ChangeMaterialColor(Spatial spatial, ColorRGBA color){
            Spatial.GetMaterial().SetColor(DIFFUSE_COLOR_KEY, color);
        }
    }
}
