namespace OopTaskProject.Shared.JME3.Items
{
    public class Spatial
    {
        private Vector3F pos;

        public Spatial()
        {
            defaultMaterial = new Material();
        }

        public Vector3F getLocalTranslation()
        {
            return pos;
        }

        public void setLocalTranslation(Vector3F pos)
        {
            this.pos = pos;
        }
        private Material defaultMaterial;

        public Material GetMaterial()
        {
            return defaultMaterial; 
        }
    }
}
