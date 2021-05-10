using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class Node : Spatial
    {
        public string Name { get; set; }
        private List<Spatial> childs;

        public Spatial FirstChild { get; private set; }

        public Node()
        {
            childs = new List<Spatial>();
        }

        public void AttachChild(Spatial child)
        {
            FirstChild = child;
            childs.Add(child);
        }

        public Node getChild(string name)
        {
            return null;
        }

        public Mesh getMesh()
        {
            return null;
        }
    }

}
