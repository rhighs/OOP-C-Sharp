using System;

namespace Montalti
{
    class SimulationCamera : ISimulationCamera
    {

        private Entity _entity;

        private Camera _camera;

        private FlyByCamera _flyByCamera;

        private readonly float MOVE_SPEED = 30f;

        private readonly float ENTITY_HEAD_OFFSET = 5f;

        public Vector3f Location 
        {
            get => _camera.GetLocation();
        }

        public Vector3f Direction
        {
            get => _camera.GetDirection();
        }

        public SimulationCamera(Camera camera, FlyByCamera flyByCamera)
        {
            _camera = camera;
            _flyByCamera = flyByCamera;
            _flyByCamera.setMoveSpeed(MOVE_SPEED);
        }

        public void update()
        {
            FollowCurrentEntity();
        }

        public void AttachEntity(Entity entity)
        {
            _entity ??= entity;
        }

        public void DetachEntity()
        {
            _entity == null ? return : _entity = null; 
        }

        private void FollowCurrentEntity(){
            if(_entity == null)
            {
                return; 
            }

            var pos = _entity.GetPosition();
            var fixedPos = new Vector3f(pos.x, pos.y + ENTITY_HEAD_OFFSET, pos.z);
            _camera.SetLocation(fixedPos);
        }
        
    }
}
