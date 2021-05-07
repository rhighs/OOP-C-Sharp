using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class Material
    {

        private Dictionary <string, ColorRGBA> materialColors;
        public Material()
        {
            materialColors = new Dictionary<string, ColorRGBA>();
        }

        public void SetColor(string key, ColorRGBA color)
        {
        }

    }
}
