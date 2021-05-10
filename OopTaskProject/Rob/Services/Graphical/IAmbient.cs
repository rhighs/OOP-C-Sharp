using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Rob
{
    public interface IAmbient
    {
        public void AddSunLight(Vector3F direction);

        public void AddShadowFilter(Vector3F lightSourceDirection);

    }
}
