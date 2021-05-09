using System.Collections;
using System.Collections.Generic;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Tests.Savi.ClassData
{
    public class NoPathIsAvailableOrComponentIsStuck : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                null, false
            };
            
            yield return new object[]
            {
                new Path.Waypoint(), true
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}