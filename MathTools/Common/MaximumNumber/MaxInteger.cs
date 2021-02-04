using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace MathTools
{
    /// <summary>
    /// Return Maximum BigInteger from a list
    /// </summary>
    public class MaxBiginteger : IMaximumNumber 
    {
        public BigInteger GetMax<BigInteger>(List<BigInteger> list) => list.Max();
    }
}
