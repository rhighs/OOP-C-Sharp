namespace OopTaskProject.Shared.JME3.Items
{
    public class BulletAppState
    {
        private PhysicsSpace physicsSpace;

        public BulletAppState()
        {
            physicsSpace = new PhysicsSpace();
        }

        public PhysicsSpace GetPhysicsSpace()
        {
            return physicsSpace;
        }
    }
}

