using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumVectors.classes;
using System;

namespace VectorTest.negativeTest
{
    [TestClass]
    public class VectorNegativeTest
    {
        [TestMethod]
        public void ConstructorDataAdapterTest ()
        {
            string[] testArgs = { "6,4" };
            Assert.ThrowsException<ArgumentException>(() => new DataAdapter(testArgs));
        }
    }

}