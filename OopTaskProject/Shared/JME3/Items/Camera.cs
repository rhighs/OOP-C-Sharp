namespace OopTaskProject.Shared.JME3.Items
{
    public class Camera
    {
        private Vector3f location;

        private Vector3f direction;

        public Camera()
        {
            location = new Vector3f(0, 0, 0);
            direction = new Vector3f(1f, 2f, 4f);
        }

        public void SetLocation(Vector3f newLocation)
        {
            location = newLocation;
        }

        public Vector3f GetDirection()
        {
            return direction;
        }

        public Vector3f GetLocation()
        {
            return location;
        }
    }
}

