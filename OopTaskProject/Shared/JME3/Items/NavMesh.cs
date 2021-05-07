using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class NavMesh
    {
        public class Cell
        {
            public Vector3f getRandomPoint()
            {
                return new Vector3f();
            }
        }

        public List<Cell> Cells { get; private set; }

        public NavMesh(Mesh mesh)
        {

        }
    }
}
