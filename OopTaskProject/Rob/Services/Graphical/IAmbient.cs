using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public interface IAmbient
    {
        public void AddSunLight(Vector3F direction);

        public void AddShadowFilter(Vector3F lightSourceDirection);

    }
}
