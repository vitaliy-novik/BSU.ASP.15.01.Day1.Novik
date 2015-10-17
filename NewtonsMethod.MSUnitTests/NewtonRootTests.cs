using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewtonsMethod.MSUnitTests
{
    [TestClass]
    public class NewtonRootTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_NegativeBasis_ExpectedArgumentException()
        {
            NewtonRoot.Root(-1, 5, 0.1);
        }

        [TestMethod]
        public void Root_5Root3Prec001()
        {
            double basis = 5.0;
            int  degree = 3;
            double precision = 0.01;
            double expected = Math.Pow(basis, 1.0/degree);

            double actual = NewtonRoot.Root(basis, degree, precision);

            Assert.AreEqual(expected, actual, precision);
        }

        [TestMethod]
        public void Root_5Root0_1Returned()
        {
            double result = NewtonRoot.Root(5, 0, 0);
            Assert.AreEqual(1, result);
        }        
    }
}
