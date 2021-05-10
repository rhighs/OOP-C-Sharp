using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Rob
{
    public class SimulationCamera : ISimulationCamera
    {

        private Camera _camera;

        private FlyByCamera _flyByCamera;

        public Entity AttachedEntity { get; private set; }

        private readonly float MOVE_SPEED = 30f;

        private readonly float ENTITY_HEAD_OFFSET = 5f;

        public Vector3F Location 
        {
            get => _camera.GetLocation();
        }

        public Vector3F Direction
        {
            get => _camera.GetDirection();
        }

        public SimulationCamera(Camera camera, FlyByCamera flyByCamera)
        {
            _camera = camera;
            _flyByCamera = flyByCamera;
            _flyByCamera.SetMoveSpeed(MOVE_SPEED);
        }

        public void update()
        {
            FollowCurrentEntity();
        }

        public void AttachToEntity(Entity entity)
        {
            AttachedEntity ??= entity;
        }

        public void DetachEntity()
        {
            if (AttachedEntity == null)
            {
                return;
            }
            AttachedEntity = null;
        }

        private void FollowCurrentEntity(){
            if(AttachedEntity == null)
            {
                return; 
            }

            var pos = AttachedEntity.Position;
            var fixedPos = new Vector3F(pos.X, pos.Y + ENTITY_HEAD_OFFSET, pos.Z);
            _camera.SetLocation(fixedPos);
        }
        
    }
}
