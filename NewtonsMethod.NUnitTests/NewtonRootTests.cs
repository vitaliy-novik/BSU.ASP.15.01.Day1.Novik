using NUnit.Framework;
using System;

namespace NewtonsMethod.NUnitTests
{
    [TestFixture]
    public class NewtonRootTests
    {
        [TestCase(5, 3, 0.1)]
        [TestCase(5, 3, 0.01)]
        [TestCase(513, 9, 0.001)]
        public void Root_PrecisionTest(double basis, int degree, double precision)
        {
            double expected = Math.Pow(basis, 1.0 / degree);

            double actual = NewtonRoot.Root(basis, degree, precision);

            Assert.AreEqual(expected, actual, precision);
        }
    }
}
