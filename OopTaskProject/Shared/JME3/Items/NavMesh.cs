using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class NavMesh
    {
        public class Cell
        {
            public Vector3F getRandomPoint()
            {
                return new Vector3F();
            }
        }

        public List<Cell> Cells { get; private set; }

        public NavMesh(Mesh mesh)
        {

        }
    }
}
