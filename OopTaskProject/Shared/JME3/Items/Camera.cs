namespace OopTaskProject.Shared.JME3.Items
{
    public class Camera
    {
        private Vector3F location;

        private Vector3F direction;

        public Camera()
        {
            location = new Vector3F(0, 0, 0);
            direction = new Vector3F(1f, 2f, 4f);
        }

        public void SetLocation(Vector3F newLocation)
        {
            location = newLocation;
        }

        public Vector3F GetDirection()
        {
            return direction;
        }

        public Vector3F GetLocation()
        {
            return location;
        }
    }
}

