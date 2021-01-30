using MathTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;

namespace MathToolsTests
{
    [TestClass]
    public class MaxNumberTest
    {
        [TestMethod]
        public void Max_Biginteger_GetMax()
        {
            //Arrange
            var list = new List<BigInteger> { 123, 1234 };
            IMaximumNumber manager = new MaxBiginteger();

            //Act
            var max = manager.GetMax<BigInteger>(list);

            //Assert
            Assert.IsTrue(max == 1234);
        }
    }
}
