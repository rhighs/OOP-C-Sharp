namespace OopTaskProject.Shared.JME3.Items
{
    public class FlyByCamera
    {
        private float moveSpeed;

        public FlyByCamera()
        {
            moveSpeed = 1f;
        }

        public void SetMoveSpeed(float speed)
        {
            moveSpeed = speed;
        }
    }
}

