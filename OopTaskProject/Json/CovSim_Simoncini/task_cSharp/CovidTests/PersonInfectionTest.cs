using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cov_sim;
namespace CovidTests
{
    [TestClass]
    public class PersonInfectionTest
    {
        [TestMethod]
        public void PersonMaskTest()
        {
            // person with FP1 UP
            Person p = new Person(Person.Mask.Protection.FP1);
            //switch to DOWN
            p.switchMaskState();
            Assert.AreEqual(Person.Mask.Status.DOWN, p.getMask().getStatus());
            Assert.AreEqual(Person.Mask.Protection.FP1, p.getMask().getProtection());
        }

        [TestMethod]
        public void InfectionTest()
        {
            Infection i = new Infection();
            //FP1 and UP
            Person p = new Person(Person.Mask.Protection.FP1);
            //switch to DOWN
            p.switchMaskState();
            //Infection probability would be to 100%
            Assert.AreEqual(true, i.apply(p));
        }
    }
}
