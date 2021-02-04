using System.Collections.Generic;
using System.Numerics;

namespace MathTools
{
    /// <summary>
    /// Calculate some value, using a list of patterns
    /// </summary>
    public interface ICalculationOnListOfPatterns
    {
        public List<BigInteger> GetValues(List<List<int>> lists);
    }
}
