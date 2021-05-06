namespace OopTaskProject.Shared
{
    public class Spatial
    {
        private Vector3f pos;

        public Vector3f getLocalTranslation()
        {
            return pos;
        }

        public void setLocalTranslation(Vector3f pos)
        {
            this.pos = pos;
        }
    }
}

