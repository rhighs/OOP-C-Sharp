using System;
using Xunit;
using OopTaskProject.Juri;

namespace OopTaskProject.Tests
{
    public class PersonInfectionTest
    {
        [Fact]
        public void PersonMaskTest()
        {
            Console.WriteLine("Testing Person Mask...");
            // person with FP1 UP
            Person p = new Person(Person.Mask.Protection.FP1);
            //switch to DOWN
            p.switchMaskState();
            Assert.Equal(Person.Mask.Status.DOWN, p.getMask().getStatus());
            Assert.Equal(Person.Mask.Protection.FP1, p.getMask().getProtection());
        }

        [Fact]
        public void InfectionTest()
        {
            Console.WriteLine("Testing Infection...");
            Infection i = new Infection();
            //FP1 and UP
            Person p = new Person(Person.Mask.Protection.FP1);
            //switch to DOWN
            p.switchMaskState();
            //Infection probability would be to 100%
            Assert.True(i.apply(p));
        }
    }
}
