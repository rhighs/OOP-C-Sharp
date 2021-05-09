using System;
using System.Threading.Tasks;
using Moq;
using OopTaskProject.Savi;
using OopTaskProject.Shared.JME3.Items;
using OopTaskProject.Tests.Savi.ClassData;
using Xunit;

namespace OopTaskProject.Tests.Savi
{
    public class MovementHandlerTests : IDisposable
    {
        private readonly Mock<IPathManager> _pathManagerMock;

        private readonly Mock<IStuckManager> _stuckManagerMock;

        private readonly IMovementHandler _movementHandler;

        public MovementHandlerTests()
        {
            _pathManagerMock = new Mock<IPathManager>();
            _stuckManagerMock = new Mock<IStuckManager>();

            _movementHandler = new MovementHandler(_pathManagerMock.Object, _stuckManagerMock.Object);
        }

        [Theory]
        [ClassData(typeof(NoPathIsAvailableOrComponentIsStuck))]
        public void UpdateAsync_Success_WhenNoPathIsAvailableOrComponentIsStuck(Path.Waypoint waypoint, bool isStuck)
        {
            Task expectedTask = new(() => { });

            _pathManagerMock.SetupGet(manager => manager.LastWaypoint).Returns(waypoint);
            _pathManagerMock.Setup(manager => manager.RequestNewPath()).Returns(expectedTask);
            _stuckManagerMock.SetupGet(manager => manager.IsStuck).Returns(isStuck);

            var resultTask = _movementHandler.UpdateAsync();

            Assert.Same(expectedTask, resultTask);

            _pathManagerMock.Verify(manager => manager.LastWaypoint, Times.Once);
            _pathManagerMock.Verify(manager => manager.RequestNewPath(), Times.Once);
            _stuckManagerMock.Verify(manager => manager.IsStuck, isStuck ? Times.Exactly(2) : Times.Once());

            if (isStuck)
            {
                _stuckManagerMock.Verify(manager => manager.Reset(), Times.Once);
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void UpdateAsync_Success_WhenNoCondition(bool isNear)
        {
            _pathManagerMock.SetupGet(manager => manager.LastWaypoint).Returns(new Path.Waypoint());
            _stuckManagerMock.SetupGet(manager => manager.IsStuck).Returns(false);
            _pathManagerMock.Setup(manager => manager.IsNear(It.IsAny<Path.Waypoint>())).Returns(isNear);

            var resultTask = _movementHandler.UpdateAsync();

            Assert.Equal(Task.CompletedTask, resultTask);

            _pathManagerMock.Verify(manager => manager.LastWaypoint, isNear ? Times.Exactly((2)) : Times.Exactly(3));
            _stuckManagerMock.Verify(manager => manager.IsStuck, Times.Once);
            _pathManagerMock.Verify(manager => manager.IsNear(It.IsAny<Path.Waypoint>()), Times.Once);
            _pathManagerMock.Verify(manager => manager.SetPosition(It.IsAny<Path.Waypoint>()), Times.Once);

            if (!isNear) return;

            _pathManagerMock.Verify(manager => manager.NextWaypoint(), Times.Once);
            _stuckManagerMock.Verify(manager => manager.Toggle(), Times.Once);
        }

        public void Dispose()
        {
            _pathManagerMock.VerifyNoOtherCalls();
            _stuckManagerMock.VerifyNoOtherCalls();
        }
    }
}