using MathTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;

namespace MathToolsTests
{
    [TestClass]
    public class SkewedMultiplesTest
    {
        [TestMethod]
        public void Get_Skewed_Multiple()
        {
            //Arrange
            var list = new List<List<int>>
            {
                new List<int> { 19, 17, 16, 15 },
                new List<int> { 29, 28, 27, 23 }
            };
            ICalculationOnListOfPatterns manager = new SkewedMultiples();

            //Act
            var multiple = manager.GetValues(list);

            //Assert
            Assert.IsTrue(multiple[0] == BigInteger.Parse("55252"));
            Assert.IsTrue(multiple[1] == BigInteger.Parse("427953"));
        }
    }
}
