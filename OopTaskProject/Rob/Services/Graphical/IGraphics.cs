using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public interface IGraphics
    {
        public void AddToScene(Spatial scene);

        public Material CreateShadedMaterial(ColorRGBA ambient, ColorRGBA diffuse);

        public void ChangeMaterialColor(Spatial spatial, ColorRGBA color);
    }
}
