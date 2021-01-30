using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MathTools
{
    /// <summary>
    /// Return maximum number from a list
    /// </summary>
    public interface IMaximumNumber
    {
        public T GetMax<T>(List<T> list);
    }
}
