﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace MathTools
{
    /// <summary>
    /// Return Maximum BigInteger from a list
    /// </summary>
    public class MaxInteger : IMaximumNumber 
    {
        public T GetMax<T>(List<T> list) => list.Max();
    }
}
