namespace OopTaskProject.Shared
{
    public class Spatial
    {
        Vector3f pos;

        public Vector3f getLocalTranslation()
        {
            return pos;
        }

        public void getLocalTranslation(Vector3f pos)
        {
            this.pos = pos;
        }
    }
}

