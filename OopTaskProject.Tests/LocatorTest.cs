using System;
using Xunit;
using OopTaskProject.Rob;
using OopTaskProject.Shared.JME3;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Tests
{

    /*
    *   just testing principal and most important cases,
    *   visibility on the scene, camera following and adding object to physics space.
    */
    public class LocatorTest
    {

        [Fact]
        public void InstancesNotNull_InstancesShouldNotBeNull()
        {
            var app = new SimpleApplication();
            var l = new Locator(app);

            Assert.NotNull(l.PhysicsService);
            Assert.NotNull(l.GraphicsService);
            Assert.NotNull(l.CamService);
            Assert.NotNull(l.InputService);
            Assert.NotNull(l.MapService);
            Assert.NotNull(l.AmbientService);
            Assert.NotNull(l.GuiNode);
        }

        [Fact]
        public void IsSpatialChildAttached_SpatialShouldBeAttachedToRootNode()
        {
            var app = new SimpleApplication();
            var l = new Locator(app);

            var spatial = new Spatial();

            l.GraphicsService.AddToScene(spatial);

            var rootNode = app.GetRootNode();
            var firstChild = rootNode.FirstChild;

            Assert.Equal(firstChild, spatial);
        }

        [Fact]
        public void IsEntityAttachedToCamera_EntityShouldBeAttachedToSimulationCamera()
        {
            var app = new SimpleApplication();
            var l = new Locator(app);

            var cam = l.CamService;
            var entity = new Entity();

            cam.AttachToEntity(entity);

            Assert.Equal(cam.AttachedEntity, entity);
        }

        [Fact]
        public void IsObjectAddedToPhysicsSpace_AnyObjectShouldBePresentInPhysicsSpace()
        {
            var app = new SimpleApplication();
            var l = new Locator(app);

            var spatial = new Spatial();
            l.PhysicsService.AddToSpace(spatial);
            var states = app.GetStateManager().States;

            var bullet = (BulletAppState) states.Find(s => s is BulletAppState);

            Assert.True(bullet.GetPhysicsSpace().Objects.Contains(spatial));
        }
    }
}
