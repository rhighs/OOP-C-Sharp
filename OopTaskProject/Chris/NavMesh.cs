using System;
using System.Collections;
using System.Collections.Generic;

namespace OopTaskProject.Chris
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
