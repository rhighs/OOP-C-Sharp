using System;


namespace Montalti
{
    interface IAmbient
    {
        public void AddSunLight(Vector3f direction);

        public void addShadowFilter(Vector3f lightSourceDirection);

        public Node RootNode { get; internal set; }
    }
}
