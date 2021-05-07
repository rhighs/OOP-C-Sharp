using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public interface IAmbient
    {
        public void AddSunLight(Vector3f direction);

        public void AddShadowFilter(Vector3f lightSourceDirection);

    }
}
