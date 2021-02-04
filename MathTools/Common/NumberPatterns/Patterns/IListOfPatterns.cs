using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MathTools.Common.NumberPatterns
{
    /// <summary>
    /// Used to implement a class that returns multiple number patterns.
    /// </summary>
    public interface IListOfPatterns
    {
        public List<List<int>> GetList(int[] args);
    }
}
