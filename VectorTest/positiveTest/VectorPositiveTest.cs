using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumVectors.classes;
using System;
namespace VectorTest.positiveTest
{
    [TestClass]
    public class VectorPositiveTest
    {
        [TestMethod]
        public void TestAddVector()
        {
            var vectorA = new Vector(3, 4);
            var vectorB = new Vector(4, 5);
            var vectorAddResult = vectorA.Add(vectorB);
            Assert.AreEqual(7,vectorAddResult.X);
            Assert.AreEqual(9,vectorAddResult.Y);
        }
        [TestMethod]
        public void TestPropVector()
        {
            Vector vectorA = new Vector(3, 4);
            Vector vectorB = new Vector(4, 5);
            double vectorPropResult = vectorA.Prop(vectorB);
            Assert.AreEqual(32, vectorPropResult);
        }
        [TestMethod]
        public void TestLengthVector()
        {
            Vector vectorA = new Vector(2, 4);
            double vectorLengthResult = vectorA.Length();
            Assert.AreEqual(Math.Sqrt(Math.Pow(vectorA.X,2) + Math.Pow(vectorA.Y,2)),
                vectorLengthResult);
        }

    }
}