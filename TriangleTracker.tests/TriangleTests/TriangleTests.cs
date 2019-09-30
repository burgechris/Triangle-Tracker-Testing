using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
    [TestClass]
    public class TriangleTests
    { 
        [TestMethod]
        public void IsTriangle_IsTriangleATriangle_True()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual(true, Triangle.IsTriangle(4, 4, 4));
        }

        [TestMethod]
        public void IsEquilateral_IsTriangleAnEquilateral_True()
        {
            Assert.AreEqual(true, Triangle.IsEquilateral(4, 4, 4));
        }

        [TestMethod]
        public void IsIsosceles_ReturnsTruthOfIsIsosceles_True()
        {
            Assert.AreEqual(true, Triangle.IsIsosceles(3, 4, 4));
        }

        [TestMethod]
        public void IsScalene_ReturnsTruthOfIsScalene_True()
        {
            Assert.AreEqual(true, Triangle.IsScalene(3, 4, 5));
        }
    }
}