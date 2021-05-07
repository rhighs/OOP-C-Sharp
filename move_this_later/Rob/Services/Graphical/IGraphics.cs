using System;

namespace Montalti
{
    interface IGraphics
    {
        public Spatial Model { get; internal set; }

        public void AddToScene(Spatial scene);

        public Material AddShadedMaterial(ColorRGBA ambient, ColorRGBA diffuse);

        public void ChangeMaterialColor(Spatial spatial, ColorRGBA color);
    }
}
