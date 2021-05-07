namespace OopTaskProject.Shared.JME3.Items
{
    public class Spatial
    {
        private Vector3f pos;
        public Spatial()
        {
            defaultMaterial = new Material();
        }

        public Vector3f getLocalTranslation()
        {
            return pos;
        }

        public void setLocalTranslation(Vector3f pos)
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
