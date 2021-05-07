namespace OopTaskProject.Shared.JME3.Items
{
    public class AssetManager
    {
        private Spatial defaultModel;

        public AssetManager()
        {
            defaultModel = new Spatial();
        }

        public Spatial LoadModel(string path)
        {
            return defaultModel;
        }

    }
}
